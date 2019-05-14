using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class BidirectionalDictionaryExtensions_Pivot
    {
        static public void PivotLeft<LEFT_TYPE, RIGHT_TYPE>(this BidirectionalDictionary<LEFT_TYPE, RIGHT_TYPE> item, LEFT_TYPE old_value, LEFT_TYPE new_value)
        {
            RIGHT_TYPE right;

            if (item.TryGetValueByLeft(old_value, out right))
                item.Update(new_value, right);
        }

        static public void PivotRight<LEFT_TYPE, RIGHT_TYPE>(this BidirectionalDictionary<LEFT_TYPE, RIGHT_TYPE> item, RIGHT_TYPE old_value, RIGHT_TYPE new_value)
        {
            LEFT_TYPE left;

            if (item.TryGetValueByRight(old_value, out left))
                item.Update(left, new_value);
        }
    }
}