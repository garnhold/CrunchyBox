using System;
using System.IO;

namespace CrunchyDough
{
    static public class StreamSystemDirectoryExtensions_Exists
    {
        static public bool DoesExist(this StreamSystemDirectory item)
        {
            return item.GetStreamSystem().DoesDirectoryExist(item.GetPath());
        }
    }
}