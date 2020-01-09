using System;
using System.IO;

namespace Crunchy.Dough
{
    static public class StreamSystemExtensions_DirectorySystem
    {
        static public StreamSystem GetPrefixSystem(this StreamSystem item, string prefix)
        {
            return new StreamSystem_PathModifier_Prefix(prefix, item);
        }

        static public StreamSystem GetDirectorySystem(this StreamSystem item, string path)
        {
            return new StreamSystem_PathModifier_Directory(path, item);
        }
    }
}