using System;
using System.IO;

namespace Crunchy.Dough
{
    static public class StreamSystemDirectoryExtensions_Exists
    {
        static public bool DoesExist(this StreamSystemDirectory item)
        {
            return item.GetStreamSystem().DoesDirectoryExist(item.GetPath());
        }
    }
}