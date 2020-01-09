using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

namespace Crunchy.Dough
{
    static public class StreamExtensions_Stream
    {
        static public void WriteStream(this Stream item, Stream stream)
        {
            if (stream != null)
            {
                int chunk_size;
                byte[] chunk = new byte[4096];

                while ((chunk_size = stream.Read(chunk)) > 0)
                    item.Write(chunk, chunk_size);
            }
        }
    }
}