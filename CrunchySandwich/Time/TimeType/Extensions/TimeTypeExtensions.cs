using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class TimeTypeExtensions
    {
        static public float GetDelta(this TimeType item)
        {
            switch (item)
            {
                case TimeType.Active: return ActiveGameTime.GetDelta();
                case TimeType.Actual: return ActualGameTime.GetDelta();
            }

            throw new UnaccountedBranchException("item", item);
        }

        static public float GetTime(this TimeType item)
        {
            switch (item)
            {
                case TimeType.Active: return ActiveGameTime.GetTime();
                case TimeType.Actual: return ActualGameTime.GetTime();
            }

            throw new UnaccountedBranchException("item", item);
        }

        static public TimeSource GetTimeSource(this TimeType item)
        {
            switch (item)
            {
                case TimeType.Active: return ActiveGameTime.INSTANCE;
                case TimeType.Actual: return ActualGameTime.INSTANCE;
            }

            throw new UnaccountedBranchException("item", item);
        }

        static public TimeType GetTimeType(this TimeSource item)
        {
            if (item.Is<ActiveGameTime>())
                return TimeType.Active;

            if (item.Is<ActualGameTime>())
                return TimeType.Actual;

            throw new UnaccountedBranchException("item", item);
        }
    }
}