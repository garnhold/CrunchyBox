using System;

namespace CrunchyDough
{
    static public class ObjectExtensions_String
    {
        static public string ToStringEX(this Object item)
        {
            if (item != null)
                return item.ToString();

            return "";
        }
    }
}