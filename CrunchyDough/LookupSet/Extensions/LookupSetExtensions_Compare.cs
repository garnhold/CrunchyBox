using System;

namespace CrunchyDough
{
    static public class LookupSetExtensions_Compare
    {
        static public bool Is<KEY_TYPE, VALUE_TYPE>(this LookupSet<KEY_TYPE, VALUE_TYPE> item, KEY_TYPE key, VALUE_TYPE value)
        {
            return item.Lookup(key).EqualsEX(value);
        }

        static public bool IsNot<KEY_TYPE, VALUE_TYPE>(this LookupSet<KEY_TYPE, VALUE_TYPE> item, KEY_TYPE key, VALUE_TYPE value)
        {
            if (item.Is(key, value) == false)
                return true;

            return false;
        }
    }
}