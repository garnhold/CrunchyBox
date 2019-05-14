using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyPantry
{
    static public class NookSystemExtensions_Nook
    {
        static public Nook GetNook(this NookSystem item, string path)
        {
            return new Nook_Basic(path, item);
        }

        static public Nook GetChangeNook(this NookSystem item, string path, Nook src_nook)
        {
            Nook dst_nook = item.GetNook(path);

            if (src_nook != null && src_nook.IsPresent())
                src_nook.MoveTo(dst_nook);

            return dst_nook;
        }

        static public IEnumerable<Nook> GetNooks(this NookSystem item, string path)
        {
            return item.GetPaths(path)
                .Convert(p => item.GetNook(p));
        }
    }
}