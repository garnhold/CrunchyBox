using System;

namespace Crunchy.Dough
{    
    static public partial class Mathq
    {
        static public int FloorToInt(float x)
        {
            return (int)Math.Floor(x);
        }

        static public int CeilToInt(float x)
        {
            return (int)Math.Ceiling(x);
        }
    }
}