using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class StreamSystemExtensions_Lines
    {
        static public AttemptResult AttemptReadLines(this StreamSystem item, string path, Process<IEnumerable<string>> process, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.AttemptRead(path, delegate(Stream stream) {
                process(stream.ReadTextLines());
            }, milliseconds);
        }

        static public AttemptResult AttemptReadLines<T>(this StreamSystem item, string path, Operation<T, IEnumerable<string>> operation, out T output, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            T temp = default(T);
            AttemptResult result = item.AttemptReadLines(path, delegate(IEnumerable<string> lines) {
                temp = operation(lines);
            }, milliseconds);

            if (result.IsDesired())
                output = temp;
            else
                output = default(T);

            return result;
        }
        static public T ReadLines<T>(this StreamSystem item, string path, Operation<T, IEnumerable<string>> operation, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            T output;

            item.AttemptReadLines<T>(path, operation, out output, milliseconds);
            return output;
        }
    }
}