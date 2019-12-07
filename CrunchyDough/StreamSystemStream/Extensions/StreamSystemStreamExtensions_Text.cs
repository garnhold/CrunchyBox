using System;
using System.IO;

namespace Crunchy.Dough
{
    static public class StreamSystemStreamExtensions_Text
    {
        static public AttemptResult WriteText(this StreamSystemStream item, string text, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.GetStreamSystem().WriteText(item.GetPath(), text, milliseconds);
        }

        static public AttemptResult AttemptReadText(this StreamSystemStream item, Process<string> process, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.GetStreamSystem().AttemptReadText(item.GetPath(), process, milliseconds);
        }

        static public AttemptResult AttemptReadText(this StreamSystemStream item, out string text, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.GetStreamSystem().AttemptReadText(item.GetPath(), out text, milliseconds);
        }
        static public string ReadText(this StreamSystemStream item, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.GetStreamSystem().ReadText(item.GetPath(), milliseconds);
        }

        static public AttemptResult AttemptReadText<T>(this StreamSystemStream item, Operation<T, string> operation, out T output, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.GetStreamSystem().AttemptReadText<T>(item.GetPath(), operation, out output, milliseconds);
        }
        static public T ReadText<T>(this StreamSystemStream item, Operation<T, string> operation, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.GetStreamSystem().ReadText<T>(item.GetPath(), operation, milliseconds);
        }
    }
}