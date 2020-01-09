using System;
using System.IO;

namespace Crunchy.Dough
{
    static public class StreamSystemStreamExtensions_Exists
    {
        static public bool DoesExist(this StreamSystemStream item)
        {
            return item.GetStreamSystem().DoesStreamExist(item.GetPath());
        }
    }
}