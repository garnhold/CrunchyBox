using System;

namespace CrunchyDough
{
    static public class DurationUnitExtensions
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
    }
}