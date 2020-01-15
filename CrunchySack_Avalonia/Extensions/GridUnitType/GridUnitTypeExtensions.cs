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
        static public GridUnitType Create(string input)
        {
            input = input.ToLower().Trim();

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
    }
}