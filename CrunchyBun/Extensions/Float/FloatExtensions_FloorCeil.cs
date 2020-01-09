using System;

namespace Crunchy.Bun
{
    using Dough;
    
    static public class FloatExtensions_FloorCeil
    {
        static public float GetFloor(this float item)
        {
            return Mathq.Floor(item);
        }

        static public float GetCeil(this float item)
        {
            return Mathq.Ceil(item);
        }
    }
}