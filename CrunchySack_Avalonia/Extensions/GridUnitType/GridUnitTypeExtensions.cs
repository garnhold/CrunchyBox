using System;
using System.IO;
using System.Text.RegularExpressions;

using Avalonia;
using Avalonia.Controls;

namespace Crunchy.Sack_Avalonia
{
    using Dough;
    using Noodle;
    using Sack;

    [Conversion]
    static public class GridUnitTypeExtensions
    {
        [Conversion]
        static public GridUnitType CreateFromDefinitionString(string input)
        {
            input = input.Solidify().ToLower().Trim();

            switch (input)
            {
                case "auto": return GridUnitType.Auto;
                case "*": return GridUnitType.Star;

                case "pixel": return GridUnitType.Pixel;
                case "px": return GridUnitType.Pixel;
                case "": return GridUnitType.Pixel;
            }

            throw new UnaccountedBranchException("input", input);
        }

        [Conversion]
        static public string ToString(GridUnitType item)
        {
            return item.GetDefinitionString();
        }
        static public string GetDefinitionString(this GridUnitType item)
        {
            switch (item)
            {
                case GridUnitType.Auto: return "auto";
                case GridUnitType.Star: return "*";

                case GridUnitType.Pixel: return "px";
            }

            throw new UnaccountedBranchException("item", item);
        }

        static public string GetDefinitionString(this GridUnitType item, double value)
        {
            switch (item)
            {
                case GridUnitType.Auto: return "auto";
                case GridUnitType.Star: return "*".PrependIf(value != 1.0, value.ToString());

                case GridUnitType.Pixel: return value + "px";
            }

            throw new UnaccountedBranchException("item", item);
        }
    }
}