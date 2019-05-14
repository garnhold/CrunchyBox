using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class Transfer
    {
        static public void StreamViaMemory(Process<Stream> spool, Process<Stream> release)
        {
            using (Stream stream = new MemoryStream())
                stream.SpoolAndRelease(spool, release);
        }
        static public T StreamViaMemory<T>(Process<Stream> spool, Operation<T, Stream> release)
        {
            using (Stream stream = new MemoryStream())
                return stream.SpoolAndRelease<T>(spool, release);
        }
        static public T StreamViaMemory<T>(Operation<T, Stream> spool, Process<Stream> release)
        {
            using (Stream stream = new MemoryStream())
                return stream.SpoolAndRelease<T>(spool, release);
        }
    }
}