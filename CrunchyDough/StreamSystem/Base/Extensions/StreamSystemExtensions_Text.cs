using System;
using System.IO;

namespace Crunchy.Dough
{
    static public class StreamSystemExtensions_Text
    {
        static public AttemptResult WriteText(this StreamSystem item, string path, string text, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.Write(path, delegate(Stream stream) {
                stream.WriteText(text);
            }, milliseconds);
        }

        static public AttemptResult AttemptReadText(this StreamSystem item, string path, Process<string> process, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.AttemptRead(path, delegate(Stream stream) {
                process(stream.ReadText());
            }, milliseconds);
        }

        static public AttemptResult AttemptReadText(this StreamSystem item, string path, out string text, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.AttemptRead(path, delegate(Stream stream) {
                return stream.ReadText();
            }, out text, milliseconds);
        }
        static public string ReadText(this StreamSystem item, string path, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            string output;

            item.AttemptReadText(path, out output, milliseconds);
            return output;
        }

        static public AttemptResult AttemptReadText<T>(this StreamSystem item, string path, Operation<T, string> operation, out T output, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            T temp = default(T);
            AttemptResult result = item.AttemptReadText(path, delegate(string text) {
                temp = operation(text);
            }, milliseconds);

            if (result.IsDesired())
                output = temp;
            else
                output = default(T);

            return result;
        }
        static public T ReadText<T>(this StreamSystem item, string path, Operation<T, string> operation, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            T output;

            item.AttemptReadText<T>(path, operation, out output, milliseconds);
            return output;
        }
    }
}