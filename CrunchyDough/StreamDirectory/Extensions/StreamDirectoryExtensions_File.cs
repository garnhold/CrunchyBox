using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class StreamDirectoryExtensions_File
    {
        static public StreamFile GetFile(this StreamDirectory item, string name)
        {
            return new StreamFile(name, item);
        }
    }
}