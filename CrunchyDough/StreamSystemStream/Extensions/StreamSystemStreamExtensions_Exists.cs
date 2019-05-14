using System;
using System.IO;

namespace CrunchyDough
{
    static public class StreamSystemStreamExtensions_Exists
    {
        static public bool DoesExist(this StreamSystemStream item)
        {
            return item.GetStreamSystem().DoesStreamExist(item.GetPath());
        }
    }
}