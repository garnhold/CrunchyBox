﻿using System;
using System.IO;

namespace CrunchyDough
{
    static public class ByteArrayExtensions_Stream
    {
        static public Stream GetStream(this byte[] item)
        {
            return item.GetMemoryStream();
        }

        static public MemoryStream GetMemoryStream(this byte[] item)
        {
            return new MemoryStream(item);
        }
    }
}