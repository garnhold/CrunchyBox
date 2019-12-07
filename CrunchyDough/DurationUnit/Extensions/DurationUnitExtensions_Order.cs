using System;

namespace Crunchy.Dough
{
    static public class DurationUnitExtensions_Order
    {
        static public DurationUnit GetLargerUnit(this DurationUnit item)
        {
            switch (item)
            {
                case DurationUnit.Milliseconds: return DurationUnit.Seconds;
                case DurationUnit.Seconds: return DurationUnit.Minutes;
                case DurationUnit.Minutes: return DurationUnit.Hours;
                case DurationUnit.Hours: return DurationUnit.Days;
                case DurationUnit.Days: return DurationUnit.Days;

                case DurationUnit.Hertz: return DurationUnit.Milliseconds;
            }

            throw new UnaccountedBranchException("item", item);
        }

        static public DurationUnit GetSmallerUnit(this DurationUnit item)
        {
            switch (item)
            {
                case DurationUnit.Milliseconds: return DurationUnit.Hertz;
                case DurationUnit.Seconds: return DurationUnit.Milliseconds;
                case DurationUnit.Minutes: return DurationUnit.Seconds;
                case DurationUnit.Hours: return DurationUnit.Minutes;
                case DurationUnit.Days: return DurationUnit.Hours;

                case DurationUnit.Hertz: return DurationUnit.Hertz;
            }

            throw new UnaccountedBranchException("item", item);
        }
    }
}