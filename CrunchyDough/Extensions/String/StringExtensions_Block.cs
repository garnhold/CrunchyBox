using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Crunchy.Dough
{
    static public class StringExtensions_Block
    {
        static public int FindIndexOfThisLine(this string item, int index)
        {
            return item.FindLastIndexOfAny(CharExtensions_Category.NEWLINE, index) + 1;
        }
        static public int FindIndexOfFirstLine(this string item)
        {
            return item.FindIndexOfThisLine(0);
        }
        static public int FindIndexOfLastLine(this string item)
        {
            return item.FindIndexOfThisLine(item.GetFinalIndex());
        }

        static public string GetIndentation(this string item, int index)
        {
            int line_start = item.FindIndexOfThisLine(index);
            int line_end = item.FindIndexOfNone(CharExtensions_Category.LINEAR_WHITESPACE, line_start);

            return item.SubSection(line_start, line_end);
        }
        static public string GetStartIndentation(this string item)
        {
            return item.GetIndentation(0);
        }
        static public string GetEndIndentation(this string item)
        {
            return item.GetIndentation(item.GetFinalIndex());
        }

        static public string PadBlock(this string item, string padding, bool pad_first_line)
        {
            string padded = item.Replace("\n", "\n" + padding);

            if (pad_first_line)
                return padding + padded;

            return padded;
        }

        static public string UnpadBlock(this string item, string padding, int spaces_per_tab = StringExtensions_Space.DEFAULT_NUMBER_SPACES_PER_TAB)
        {
            int number_padding_tabs = padding.Count("\t");
            int number_padding_spaces = padding.Count(" ");

            return item.RegexReplace("(^|[\n\r]+)([ \t]+)", delegate(Match match){
                string indent = match.Groups[2].Value;

                int number_new_tabs = indent.Count("\t") - number_padding_tabs;
                int number_new_spaces = indent.Count(" ") - number_padding_spaces;

                if (number_new_tabs < 0)
                    number_new_spaces += number_new_tabs * spaces_per_tab;

                if (number_new_spaces < 0)
                    number_new_tabs += number_new_spaces / spaces_per_tab;

                return match.Groups[1].Value + StringIndentation_Tab.GetString(number_new_tabs) + StringIndentation_Space.GetString(number_new_spaces);
            });
        }

        static public string PrepareBlockForInsert(this string item, string block, int index)
        {
            return block.PadBlock(item.GetIndentation(index), false);
        }

        static public string PrepareBlockForRemoval(this string item, int spaces_per_tab = StringExtensions_Space.DEFAULT_NUMBER_SPACES_PER_TAB)
        {
            return item.UnpadBlock(item.GetStartIndentation(), spaces_per_tab);
        }
    }
}