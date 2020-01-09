using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections;

using Crunchy.Dough;
using Crunchy.Salt;

using UnityUtilities;

public class OrphanPurger
{
    private HashSet<string> referenced_guids;

    public OrphanPurger()
    {
        referenced_guids = new HashSet<string>();
    }

    public void Clear()
    {
        referenced_guids.Clear();
    }

    public void LoadReferences(string filepath)
    {
        UnityAssetFile.GetUnityAssetFiles(filepath)
            .Process(p => LoadReferencesFromFile(p));
    }
    public void LoadReferencesFromFile(string filepath)
    {
        string text = File.ReadAllText(filepath);

        referenced_guids.AddRange(
            text.RegexMatches("guid\\s*:\\s*([a-f0-9]{32})")
                .Bridge<Match>()
                .Convert(m => m.Groups[1].Value)
        );
    }

    public int PurgeOrphans(string filepath)
    {
        return UnityAssetFile.GetUnityAssetFiles(filepath)
            .Skip(p => IsFileReferenced(p))
            .ProcessAndCount(p => File.Delete(p));
    }

    public bool IsFileReferenced(string filepath)
    {
        if (referenced_guids.Contains(UnityAssetFile.GetGUID(filepath)))
            return true;

        return false;
    }
}