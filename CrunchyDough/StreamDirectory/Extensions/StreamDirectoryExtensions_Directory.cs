using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class StreamDirectoryExtensions_Directory
    {
        static public StreamDirectory GetDirectory(this StreamDirectory item, string name)
        {
            return new StreamDirectory(name, item);
        }
    }
}