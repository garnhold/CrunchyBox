using System;
using System.Text;

namespace Crunchy.Dough
{
    static public partial class Strings
    {
        static public string PseudoRandom(int length)
        {
            StringBuilder builder = new StringBuilder();

            while (builder.Length < length)
            {
                builder.Append(
                    HashTypes.SHA1.CalculateAsUnicode(Guid.NewGuid().ToString())
                        .ToHexString()
                );
            }

            return builder.ToString().Truncate(length);
        }
    }
}