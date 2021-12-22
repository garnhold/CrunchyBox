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

        static public int GetRotatingHashCodeEX(this Object item, long milliseconds)
        {
            return item.GetHashCodeEX()
                .AbsorbObjectHash(TimeSource_System.INSTANCE.GetCurrentTimeInMilliseconds() / milliseconds);
        }
        static public int GetRotatingHashCodeEX(this Object item, Duration duration)
        {
            return item.GetRotatingHashCodeEX(duration.GetWholeMilliseconds());
        }

        static public int GetFastRotatingHashCodeEX(this Object item)
        {
            return item.GetRotatingHashCodeEX(Duration.Hertz(4.0f));
        }
        static public int GetNormalRotatingHashCodeEX(this Object item)
        {
            return item.GetRotatingHashCodeEX(Duration.Seconds(4.0f));
        }
        static public int GetSlowRotatingHashCodeEX(this Object item)
        {
            return item.GetRotatingHashCodeEX(Duration.Minutes(1.0f));
        }
    }
}