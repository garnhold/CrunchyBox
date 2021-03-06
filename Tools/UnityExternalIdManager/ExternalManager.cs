﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections;

using Mono.Cecil;

using Crunchy.Dough;
using Crunchy.Salt;
using Crunchy.Pepper;
using Crunchy.Recipe;

using UnityUtilities;

public class ExternalManager
{
    private ExternalTypeDatabase working_database;
    private ExternalTypeDatabase reference_database;

    private ExternalType Migrate(ExternalTypeReference reference, string hint)
    {
        int index;

        string search_string;
        string index_string;
        List<ExternalType> results;

        Console.WriteLine("----------------Missing Type---------------");
        Console.WriteLine(reference.GetYAML());
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine(hint.Truncate(512));
        Console.WriteLine("-------------------------------------------");

        do
        {
            Console.Write("Search: ");
            search_string = Console.ReadLine();

            if (search_string == "skip")
                return null;
                
            results = working_database.GetTypes()
                .Narrow(t => t.GetFullName().Contains(search_string))
                .Sort(t => t.GetFullName().Length)
                .Truncate(10)
                .ToList();

            for (int i = 0; i < results.Count; i++)
                Console.WriteLine(i + " : " + results[i].GetFullName());

            Console.Write("Index: ");
            index_string = Console.ReadLine();

            if (index_string == "skip")
                return null;

        } while (index_string.TryParseInt(out index) == false || results.IsIndexValid(index) == false);

        return results[index];
    }

    public ExternalManager()
    {
        working_database = new ExternalTypeDatabase();
        reference_database = new ExternalTypeDatabase();
    }

    public void LoadDatabase(string filepath)
    {
        reference_database.Load(filepath);
    }

    public void LoadCurrentTypes(string filepath)
    {
        working_database.Create(filepath);
        working_database.Save(filepath + "/external_types.tyon");
    }

    public void ValidateFiles(string filepath)
    {
        UnityAssetFile.GetUnityAssetFiles(filepath)
            .Process(p => ValidateFile(p));
    }
    public void ValidateFile(string filepath)
    {
        string text = File.ReadAllText(filepath);

        string modified_text = text.RegexReplace("m_Script\\s*:\\s*{\\s*fileID\\s*:\\s*([-0-9]+)\\s*,\\s*guid\\s*:\\s*([A-Za-z0-9_]+)\\s*,\\s*type\\s*:\\s*3\\s*}(.*?)(?=m_Script|$)", delegate (Match match) {
            string trailing = match.Groups[3].Value;
            ExternalTypeReference reference = new ExternalTypeReference(match.Groups[1].Value, match.Groups[2].Value);

            if (reference.IsValid())
            {
                ExternalType resolved = Resolve(reference, filepath + "\n\n" + trailing);

                if (resolved != null)
                {
                    ExternalTypeReference resolved_reference = resolved.GetReference();

                    if (resolved_reference.NotEqualsEX(reference))
                        return resolved_reference.GetYAML() + trailing;
                }
            }

            return match.Value;
        });

        if (modified_text != text)
        {
            File.WriteAllText(filepath, modified_text);
            Console.WriteLine(filepath + " was modified.");
        }
    }

    public ExternalType Resolve(ExternalTypeReference reference, string hint)
    {
        return working_database.Resolve(reference, delegate() {
            return Migrate(
                reference,
                reference_database.Resolve(reference).IfNotNull(r => r.GetFullName()) ?? hint
            );
        });
    }
}