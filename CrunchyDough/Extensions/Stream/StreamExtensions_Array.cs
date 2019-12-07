using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

namespace Crunchy.Dough
{
    static public class StreamExtensions_Array
    {
        static public void Write(this Stream item, byte[] array, int length)
        {
            item.Write(array, 0, length);
        }
        static public void Write(this Stream item, byte[] array)
        {
            item.Write(array, array.Length);
        }

        static public int Read(this Stream item, byte[] array, int length)
        {
            return item.Read(array, 0, length);
        }
        static public int Read(this Stream item, byte[] array)
        {
            return item.Read(array, array.Length);
        }
    }
}