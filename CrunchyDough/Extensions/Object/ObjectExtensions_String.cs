using System;

namespace Crunchy.Dough
{
    static public class ObjectExtensions_String
    {
        static public string ToStringEX(this Object item, string null_string = "")
        {
            if (item != null)
                return item.ToString();

            return null_string;
        }

        static public bool IsToStringOverridden(this Object item)
        {
            if (item != null)
            {
                if (item.ToString() != item.GetType().ToString())
                    return true;
            }

            return false;
        }

        static public string ToDebugString(this Object item)
        {
            if (item != null)
            {
                Type type = item.GetType();

                if (type.IsString())
                    return ((string)item).StyleAsDoubleQuoteLiteral();

                return item.ToString();
            }

            return "null";
        }
    }
}