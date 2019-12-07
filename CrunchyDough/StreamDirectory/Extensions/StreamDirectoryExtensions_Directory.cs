using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class StreamDirectoryExtensions_Directory
    {
        static public StreamDirectory GetDirectory(this StreamDirectory item, string name)
        {
            return new StreamDirectory(name, item);
        }

        static public StreamDirectory GetDirectory(this StreamDirectory item, IEnumerable<string> names)
        {
            return names.Apply(item, (d, n) => d.GetDirectory(n));
        }
        static public StreamDirectory GetDirectory(this StreamDirectory item, params string[] names)
        {
            return item.GetDirectory((IEnumerable<string>)names);
        }
    }
}