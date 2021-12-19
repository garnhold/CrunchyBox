using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class ObjectExtensions_Compare
    {
        static public bool EqualsEX(this Object item, Object obj)
        {
            if (item != null)
                return item.Equals(obj);

            if (obj != null)
                return obj.Equals(item);

            return true;
        }

        static public bool NotEqualsEX(this Object item, Object obj)
        {
            if (item.EqualsEX(obj) == false)
                return true;

            return false;
        }

        static public int GetHashCodeEX(this Object item)
        {
            if (item != null)
                return item.GetHashCode();

            return 0;
        }

        static public int GetTimedHashCodeEX(this Object item, long milliseconds)
        {
            return item.GetHashCodeEX().AbsorbObjectHash(DateTime.Now.Ticks / milliseconds);
        }
        static public int GetTimedHashCodeEX(this Object item, Duration duration)
        {
            return item.GetTimedHashCodeEX(duration.GetWholeMilliseconds());
        }
    }
}