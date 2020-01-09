using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class KeyValuePair
    {
        static public KeyValuePair<KEY_TYPE, VALUE_TYPE> New<KEY_TYPE, VALUE_TYPE>(KEY_TYPE key, VALUE_TYPE value)
        {
            return new KeyValuePair<KEY_TYPE, VALUE_TYPE>(key, value);
        }
    }
}