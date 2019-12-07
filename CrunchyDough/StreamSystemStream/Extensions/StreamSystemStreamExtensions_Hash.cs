using System;
using System.IO;

namespace Crunchy.Dough
{
    static public class StreamSystemStreamExtensions_Hash
    {
        static public ByteSequence GetHash(this StreamSystemStream item, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.GetStreamSystem().GetStreamHash(item.GetPath(), milliseconds);
        }
    }
}