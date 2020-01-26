using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class VectorF2Extensions_Normal
    {
        static public VectorF2 GetNormal(this VectorF2 item)
        {
            return new VectorF2(-item.y, item.x);
        }
        static public VectorF2 GetNormal(this VectorF2 item, VectorF2 point)
        {
            return (point - item).GetNormal();
        }

        static public VectorF2 GetNormalizedNormal(this VectorF2 item)
        {
            return item.GetNormal().GetNormalized();
        }
        static public VectorF2 GetNormalizedNormal(this VectorF2 item, VectorF2 point)
        {
            return (point - item).GetNormalizedNormal();
        }

        static public VectorF2 GetNormalizedNormal(this VectorF2 item, VectorF2 before, VectorF2 after)
        {
            return (before.GetNormalizedNormal(item) + item.GetNormalizedNormal(after)) * 0.5f;
        }
    }
}