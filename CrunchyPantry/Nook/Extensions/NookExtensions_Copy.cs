using System;
using System.IO;

using CrunchyDough;

namespace CrunchyPantry
{
    static public class NookExtensions_Copy
    {
        static public bool CopyTo(this Nook item, Nook dst_nook)
        {
            bool result = false;

            item.Read(delegate(Stream src_stream) {
                result = dst_nook.WriteFromStream(src_stream);
            });

            return result;
        }
    }
}