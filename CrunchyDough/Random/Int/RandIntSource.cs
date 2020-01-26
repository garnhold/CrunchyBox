using System;

namespace Crunchy.Dough
{    
    public abstract class RandIntSource
    {
        public abstract int Get();

        public int GetMagnitude(int m)
        {
            if (m != 0)
                return Get() % m;

            return 0;
        }

        public int GetIndex(int count)
        {
            return GetMagnitude(count);
        }

        public int GetOffset(int radius)
        {
            return GetMagnitude(radius * 2) - radius;
        }

        public int GetVariance(int x, int radius)
        {
            return x + GetMagnitude(radius);
        }
        public int GetVariance(IntVariance variance)
        {
            return GetVariance(variance.value, variance.radius);
        }

        public int GetBetween(int a, int b)
        {
            int low;
            int high;

            a.Order(b, out low, out high);
            return low + GetMagnitude(high - low);
        }
        public int GetBetween(IntRange range)
        {
            return GetBetween(range.x1, range.x2);
        }
    }
}