using System;

namespace CrunchyDough
{
    static public class ObjectExtensions_String
    {
        static public string ToStringEX(this Object item, string null_string = "")
        {
            if (item != null)
                return item.ToString();

            return null_string;
        }
    }
}