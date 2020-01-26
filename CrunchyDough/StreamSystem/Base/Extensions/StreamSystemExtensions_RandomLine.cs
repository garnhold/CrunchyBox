using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class StreamSystemExtensions_RandomLine
    {
        static public AttemptResult AttemptReadRandomLine(this StreamSystem item, string path, Process<string> process, RandIntSource source, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.AttemptRead(path, delegate(Stream stream) {
                process(stream.ReadTextRandomLine(source));
            }, milliseconds);
        }
        static public AttemptResult AttemptReadRandomLine(this StreamSystem item, string path, Process<string> process, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.AttemptReadRandomLine(path, process, RandInt.SOURCE, milliseconds);
        }

        static public AttemptResult AttemptReadRandomLine<T>(this StreamSystem item, string path, Operation<T, string> operation, out T output, RandIntSource source, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            T temp = default(T);
            AttemptResult result = item.AttemptReadRandomLine(path, delegate(string line) {
                temp = operation(line);
            }, source, milliseconds);

            if (result.IsDesired())
                output = temp;
            else
                output = default(T);

            return result;
        }
        static public AttemptResult AttemptReadRandomLine<T>(this StreamSystem item, string path, Operation<T, string> operation, out T output, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.AttemptReadRandomLine<T>(path, operation, out output, RandInt.SOURCE, milliseconds);
        }

        static public T ReadRandomLine<T>(this StreamSystem item, string path, Operation<T, string> operation, RandIntSource source, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            T output;

            item.AttemptReadRandomLine<T>(path, operation, out output, source, milliseconds);
            return output;
        }
        static public T ReadRandomLine<T>(this StreamSystem item, string path, Operation<T, string> operation, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.ReadRandomLine<T>(path, operation, RandInt.SOURCE, milliseconds);
        }

        static public AttemptResult AttemptReadRandomLine(this StreamSystem item, string path, out string output, RandIntSource source, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.AttemptReadRandomLine(path, s => s, out output, source, milliseconds);
        }
        static public AttemptResult AttemptReadRandomLine(this StreamSystem item, string path, out string output, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.AttemptReadRandomLine(path, out output, RandInt.SOURCE, milliseconds);
        }

        static public string ReadRandomLine(this StreamSystem item, string path, RandIntSource source, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            string output;

            item.AttemptReadRandomLine(path, out output, source, milliseconds);
            return output;
        }
        static public string ReadRandomLine(this StreamSystem item, string path, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.ReadRandomLine(path, RandInt.SOURCE, milliseconds);
        }
    }
}