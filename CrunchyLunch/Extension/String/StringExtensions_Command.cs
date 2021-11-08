using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Crunchy.Lunch
{
    static public class StringExtensions_Command
    {
        static public string EscapeCommand(this string item)
        {
            if (item != null)
            {
                int number_backslashes = 0;
                string as_string = item.ToString();

                StringBuilder builder = new StringBuilder();

                builder.Append('"');
                foreach (char c in as_string)
                {
                    if (c == '\\')
                        number_backslashes++;
                    else
                    {
                        if (c == '"')
                        {
                            builder.Append('\\', number_backslashes * 2 + 1);
                            builder.Append('"');
                        }
                        else
                        {
                            builder.Append('\\', number_backslashes);
                            builder.Append(c);
                        }

                        number_backslashes = 0;
                    }
                }

                builder.Append('\\', number_backslashes * 2);
                builder.Append('"');

                return builder.ToString();
            }

            return "";
        }
    }
}