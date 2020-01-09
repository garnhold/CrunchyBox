using System;
using System.Text;

namespace Crunchy.Dough
{
    static public class StringBuilderExtensions
    {
        static public void Clear(this StringBuilder item)
        {
            item.Length = 0;
        }
    }
}