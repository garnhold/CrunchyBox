using System;
using System.IO;

namespace Crunchy.Pantry
{
    using Dough;
    
    static public class NookExtensions_Read
    {
        static public bool ReadIntoStream(this Nook item, Stream dst_stream)
        {
            return item.Read(delegate(Stream src_stream) {
                dst_stream.WriteStream(src_stream);
            });
        }

        static public bool TryReadText(this Nook item, out string text)
        {
            string temp = null;
            bool result = item.Read(delegate(Stream stream) {
                temp = stream.ReadText();
            });

            text = temp;
            return result;
        }
        static public string ReadText(this Nook item)
        {
            string text;

            item.TryReadText(out text);
            return text;
        }
    }
}