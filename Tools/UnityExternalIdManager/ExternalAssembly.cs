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

using UnityUtilities;

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

    public AssemblyDefinition GetAssemblyDefinition()
    {
        if (assembly == null)
            assembly = AssemblyDefinition.ReadAssembly(GetPath());

        return assembly;
    }

    public string GetGUID()
    {
        if (guid.IsBlank())
            guid = UnityAssetFile.GetGUID(GetPath());

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