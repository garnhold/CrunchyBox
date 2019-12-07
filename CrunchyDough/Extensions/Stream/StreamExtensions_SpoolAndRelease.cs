using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

namespace Crunchy.Dough
{
    static public class StreamExtensions_SpoolAndRelease
    {
        static public void SpoolAndRelease(this Stream item, Process<Stream> spool, Process<Stream> release)
        {
            long start_position = item.Position;

            spool(item);

            item.Position = start_position;
            release(item);
        }
        static public T SpoolAndRelease<T>(this Stream item, Operation<T, Stream> spool, Process<Stream> release)
        {
            T return_value = default(T);

            item.SpoolAndRelease(delegate(Stream stream) {
                return_value = spool(stream);
            }, release);

            return return_value;
        }
        static public T SpoolAndRelease<T>(this Stream item, Process<Stream> spool, Operation<T, Stream> release)
        {
            T return_value = default(T);

            item.SpoolAndRelease(spool, delegate(Stream stream) {
                return_value = release(stream);
            });

            return return_value;
        }
    }
}