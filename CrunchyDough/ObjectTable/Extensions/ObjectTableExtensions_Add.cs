using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class ObjectTableExtensions_Add
    {
        static public VALUE_TYPE AddAndGet<OBJECT_TYPE, VALUE_TYPE>(this ObjectTable<OBJECT_TYPE, VALUE_TYPE> item, OBJECT_TYPE key, VALUE_TYPE value) where OBJECT_TYPE : class
        {
            item.Add(key, value);

            return value;
        }

        static public VALUE_TYPE SetAndGet<OBJECT_TYPE, VALUE_TYPE>(this ObjectTable<OBJECT_TYPE, VALUE_TYPE> item, OBJECT_TYPE key, VALUE_TYPE value) where OBJECT_TYPE : class
        {
            item.Set(key, value);

            return value;
        }
    }
}