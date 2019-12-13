using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections;

using Mono.Cecil;

using Crunchy.Dough;
using Crunchy.Salt;
using Crunchy.Pepper;

public class ExternalTypeReference
{
    [SerializeField] private int file_id;
    [SerializeField] private string guid;

    [SerializeField] private ExternalType resolved_type;

    public ExternalTypeReference(int i, string g, ExternalType rt)
    {
        file_id = i;
        guid = g;

        resolved_type = rt;
    }

    public ExternalTypeReference(int i, string g) : this(i, g, null) { }
    public ExternalTypeReference(string i, string g) : this(i.ParseInt(), g) { }

    public bool IsValid()
    {
        if (file_id == 0)
            return false;

        if (file_id == 11500000)
            return false;

        if (file_id == 21300000)
            return false;

        return true;
    }

    public int GetFileId()
    {
        return file_id;
    }

    public string GetGUID()
    {
        return guid;
    }

    public string GetYAML()
    {
        return "m_Script: { " + "fileID: " + file_id + ", guid: " + guid + ", type: 3}";
    }

    public override int GetHashCode()
    {
        unchecked
        {
            int hash = 17;

            hash = hash * 23 + file_id.GetHashCode();
            hash = hash * 23 + guid.GetHashCode();
            return hash;
        }
    }

    public override bool Equals(object obj)
    {
        ExternalTypeReference cast;

        if (obj.Convert<ExternalTypeReference>(out cast))
        {
            if (cast.file_id == file_id)
            {
                if (cast.guid == guid)
                    return true;
            }
        }

        return false;
    }
}