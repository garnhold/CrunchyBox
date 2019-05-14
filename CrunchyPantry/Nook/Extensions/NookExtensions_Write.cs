using System;
using System.IO;

using CrunchyDough;

namespace CrunchyPantry
{
    static public class NookExtensions_Write
    {
        static public bool WriteFromStream(this Nook item, Stream src_stream)
        {
            return item.Write(delegate(Stream dst_stream) {
                dst_stream.WriteStream(src_stream);
            });
        }

        static public bool WriteText(this Nook item, string text)
        {
            return item.Write(delegate(Stream stream) {
                stream.WriteText(text);
            });
        }

        static public bool WriteData(this Nook item, byte[] data)
        {
            return item.Write(delegate(Stream stream) {
                stream.Write(data);
            });
        }

        static public bool WriteEmpty(this Nook item)
        {
            return item.Write(delegate(Stream stream) { });
        }
    }
}