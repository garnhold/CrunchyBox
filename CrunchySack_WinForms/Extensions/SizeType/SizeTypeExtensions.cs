using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using System.Windows.Forms;

namespace Crunchy.Sack_WinForms
{
    using Dough;
    using Noodle;
    using Sack;

    [Conversion]
    static public class SizeTypeExtensions
    {
        [Conversion]
        static public SizeType CreateFromDefinitionString(string input)
        {
            input = input.Solidify().ToLower().Trim();

            switch (input)
            {
                case "auto": return SizeType.AutoSize;
                case "*": return SizeType.Percent;

                case "pixel": return SizeType.Absolute;
                case "px": return SizeType.Absolute;
                case "": return SizeType.Absolute;
            }

            throw new UnaccountedBranchException("input", input);
        }

        [Conversion]
        static public string ToString(SizeType item)
        {
            return item.GetDefinitionString();
        }
        static public string GetDefinitionString(this SizeType item)
        {
            switch (item)
            {
                case SizeType.AutoSize: return "auto";
                case SizeType.Percent: return "*";

                case SizeType.Absolute: return "px";
            }

            throw new UnaccountedBranchException("item", item);
        }

        static public string GetDefinitionString(this SizeType item, float width)
        {
            switch (item)
            {
                case SizeType.AutoSize: return "auto";
                case SizeType.Percent: return "*".PrependIf(width != 1.0f, width.ToString());

                case SizeType.Absolute: return width + "px";
            }

            throw new UnaccountedBranchException("item", item);
        }
    }
}