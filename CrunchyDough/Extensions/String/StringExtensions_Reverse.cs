using System;
using System.Text;

namespace Crunchy.Dough
{
    static public class StringExtensions_Reverse
    {
        static public string Reverse(this string item)
        {
            if (item != null)
            {
                StringBuilder builder = new StringBuilder(item.Length);

                for (int i = item.Length - 1; i >= 0; i--)
                    builder.Append(item[i]);

                return builder.ToString();
            }

            return null;
        }
    }
}