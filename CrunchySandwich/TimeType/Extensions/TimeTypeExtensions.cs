using System;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class TimeTypeExtensions
    {
        static public TimeSource GetTimeSource(this TimeType item)
        {
            switch (item)
            {
                case TimeType.Active: return ActiveGameTime.INSTANCE;
                case TimeType.Actual: return GameTime.INSTANCE;
            }

            throw new UnaccountedBranchException("item", item);
        }
    }
}