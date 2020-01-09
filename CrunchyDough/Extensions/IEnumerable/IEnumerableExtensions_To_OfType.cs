using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_To_OfType
    {
        static public Array ToArrayOfType<T>(this IEnumerable<T> item, Type type)
        {
            List<T> list = item.ToList();
            Array array = type.CreateArrayInstance(list.Count);

            list.ProcessWithIndex((i, e) => array.SetValue(e.ConvertToType(type), i));
            return array;
        }
    }
}