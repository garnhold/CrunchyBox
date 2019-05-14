using System;
using System.IO;

namespace CrunchyDough
{
    static public class StreamSystemDirectoryExtensions_StreamSystem
    {
        static public StreamSystem CreateStreamSystem(this StreamSystemDirectory item)
        {
            return item.GetStreamSystem().GetDirectorySystem(item.GetPath());
        }
    }
}