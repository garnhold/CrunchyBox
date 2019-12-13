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

public class ExternalType
{
    [SerializeField]private string type_namespace;
    [SerializeField]private string type_name;

    [SerializeField]private ExternalAssembly assembly;

    private int file_id;

    static public ExternalType CreateExternalType(TypeDefinition type, ExternalAssembly assembly)
    {
        return new ExternalType(
            type.Namespace,
            type.Name,
            assembly
        );
    }

    public ExternalType(string ns, string n, ExternalAssembly a)
    {
        type_namespace = ns;
        type_name = n;

        assembly = a;
    }

    public string GetNamespace()
    {
        return type_namespace;
    }

    public string GetName()
    {
        return type_name;
    }

    public string GetFullName()
    {
        return GetNamespace() + "." + GetName();
    }

    public int GetFileId()
    {
        if (file_id == 0)
            file_id = FileId.Calculate(type_namespace, type_name);

        return file_id;
    }

    public string GetGUID()
    {
        return assembly.GetGUID();
    }

    public ExternalTypeReference GetReference()
    {
        return new ExternalTypeReference(GetFileId(), GetGUID(), this);
    }

    public override int GetHashCode()
    {
        unchecked
        {
            int hash = 17;

            hash = hash * 23 + type_namespace.GetHashCode();
            hash = hash * 23 + type_name.GetHashCode();
            hash = hash * 23 + assembly.GetGUID().GetHashCode();
            return hash;
        }
    }

    public override bool Equals(object obj)
    {
        ExternalType cast;

        if (obj.Convert<ExternalType>(out cast))
        {
            if (cast.type_namespace == type_namespace)
            {
                if (cast.type_name == type_name)
                {
                    if (cast.assembly.GetGUID() == assembly.GetGUID())
                        return true;
                }
            }
        }

        return false;
    }
}