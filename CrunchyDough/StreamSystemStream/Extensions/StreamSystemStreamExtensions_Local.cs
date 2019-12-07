using System;
using System.IO;

namespace Crunchy.Dough
{
    static public class StreamSystemStreamExtensions_Local
    {
        static public bool TryGetLocalPath(this StreamSystemStream item, out string local_path)
        {
            return item.GetStreamSystem().TryGetLocalPath(item.GetPath(), out local_path);
        }
    }
}