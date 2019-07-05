using System;

using CrunchyDough;

namespace CrunchyBun
{
    static public class RandInt
    {
        static public readonly RandIntSource SOURCE = new RandIntSource_System(new Random());

        static public int Get()
        {
            return SOURCE.Get();
        }

        static public int GetMagnitude(int m)
        {
            return SOURCE.GetMagnitude(m);
        }

        static public int GetIndex(int count)
        {
            return SOURCE.GetIndex(count);
        }

        static public int GetOffset(int radius)
        {
            return SOURCE.GetOffset(radius);
        }

        static public int GetVariance(int center, int radius)
        {
            return SOURCE.GetVariance(center, radius);
        }

        static public int GetBetween(int a, int b)
        {
            return SOURCE.GetBetween(a, b);
        }
        static public int GetBetween(IntRange range)
        {
            return SOURCE.GetBetween(range.x1, range.x2);
        }
    }
}