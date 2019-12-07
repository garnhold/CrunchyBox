using System;

namespace Crunchy.Dough
{
    static public class DurationUnitExtensions_Suffix
    {
        static public string GetUnitSuffix(this DurationUnit item)
        {
            switch (item)
            {
                case DurationUnit.Milliseconds: return "ms";
                case DurationUnit.Seconds: return "s";
                case DurationUnit.Minutes: return "m";
                case DurationUnit.Hours: return "h";
                case DurationUnit.Days: return "d";

                case DurationUnit.Hertz: return "hz";
            }

            throw new UnaccountedBranchException("item", item);
        }

        static public DurationUnit GetUnitBySuffix(string suffix)
        {
            switch (suffix.ToLower())
            {
                case "ms": return DurationUnit.Milliseconds;
                case "s": return DurationUnit.Seconds;
                case "m": return DurationUnit.Minutes;
                case "h": return DurationUnit.Hours;
                case "d": return DurationUnit.Days;

                case "hz": return DurationUnit.Hertz;
            }

            return DurationUnit.Seconds;
        }
    }
}