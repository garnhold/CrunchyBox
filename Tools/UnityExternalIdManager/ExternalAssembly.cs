using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

using Mono.Cecil;

using Crunchy.Dough;
using Crunchy.Salt;
using Crunchy.Pepper;

public class ExternalAssembly
{
    [SerializeField]private string path;

    private AssemblyDefinition assembly;
    private string guid;

    static public ExternalAssembly LoadExternalAssembly(string path)
    {
        Console.WriteLine("Loading " + path);

        return new ExternalAssembly(path);
    }

    public ExternalAssembly(string p)
    {
        path = p;
    }

    public string GetPath()
    {
        return path;
    }

    public string GetMetaPath()
    {
        return GetPath() + ".meta";
    }

    public AssemblyDefinition GetAssemblyDefinition()
    {
        if (assembly == null)
            assembly = AssemblyDefinition.ReadAssembly(GetPath());

        return assembly;
    }

    public string GetGUID()
    {
        if (guid.IsBlank())
        {
            guid = File.ReadAllText(GetMetaPath())
               .RegexMatches("guid\\s*:\\s*([A-Za-z0-9_]+)")[0]
                .Groups[1].Value;
        }

        return guid;
    }

    public IEnumerable<ExternalType> GetExternalTypes()
    {
        return GetAssemblyDefinition()
            .GetTypes()
            .Skip(t => t.IsSpecial())
            .Convert(t => ExternalType.CreateExternalType(t, this));
    }
}