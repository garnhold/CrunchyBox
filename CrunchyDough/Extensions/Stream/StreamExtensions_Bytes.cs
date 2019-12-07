using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

namespace Crunchy.Dough
{
    static public class StreamExtensions_Bytes
    {
        static public void WriteBytes(this Stream item, byte[] bytes)
        {
            item.Write(bytes);
        }

        static public byte[] ReadBytes(this Stream item)
        {
            MemoryStream memory_stream = new MemoryStream();

            memory_stream.WriteStream(item);
            return memory_stream.GetBuffer();
        }
    }
}