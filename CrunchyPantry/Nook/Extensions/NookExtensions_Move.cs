using System;
using System.IO;

namespace Crunchy.Pantry
{
    using Dough;
    
    static public class NookExtensions_Move
    {
        static public bool MoveTo(this Nook item, Nook dst_nook)
        {
            if (item.CopyTo(dst_nook))
            {
                item.Delete();
                return true;
            }

            return false;
        }
    }
}