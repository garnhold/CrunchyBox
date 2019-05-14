using System;
using System.Text;

namespace CrunchyDough
{
    static public class StringBuilderExtensions
    {
        static public void Clear(this StringBuilder item)
        {
            item.Length = 0;
        }
    }
}