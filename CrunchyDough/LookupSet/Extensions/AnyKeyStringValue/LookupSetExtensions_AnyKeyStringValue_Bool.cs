using System;

namespace Crunchy.Dough
{
    static public class LookupSetExtensions_AnyKeyStringValue_Bool
    {
        static public bool IsTrue<KEY_TYPE>(this LookupSet<KEY_TYPE, string> item, KEY_TYPE key)
        {
            return item.Lookup(key).ParseBool();
        }

        static public bool IsFalse<KEY_TYPE>(this LookupSet<KEY_TYPE, string> item, KEY_TYPE key)
        {
            if (item.IsTrue(key) == false)
                return true;

            return false;
        }

        static public T ConvertBool<KEY_TYPE, T>(this LookupSet<KEY_TYPE, string> item, KEY_TYPE key, T if_true, T if_false)
        {
            return item.IsTrue(key).ConvertBool<T>(if_true, if_false);
        }

        static public T ConvertBool<KEY_TYPE, T>(this LookupSet<KEY_TYPE, string> item, KEY_TYPE key, T if_true)
        {
            return item.IsTrue(key).ConvertBool<T>(if_true);
        }
    }
}