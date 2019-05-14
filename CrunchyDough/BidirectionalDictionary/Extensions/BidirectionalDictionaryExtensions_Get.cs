using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class BidirectionalDictionaryExtensions_Get
    {
        static public RIGHT_TYPE GetValueByLeft<LEFT_TYPE, RIGHT_TYPE>(this BidirectionalDictionary<LEFT_TYPE, RIGHT_TYPE> item, LEFT_TYPE left, RIGHT_TYPE default_value)
        {
            RIGHT_TYPE right;

            if (item.TryGetValueByLeft(left, out right) == false)
                right = default_value;

            return right;
        }
        static public RIGHT_TYPE GetValueByLeft<LEFT_TYPE, RIGHT_TYPE>(this BidirectionalDictionary<LEFT_TYPE, RIGHT_TYPE> item, LEFT_TYPE left)
        {
            return item.GetValueByLeft(left, default(RIGHT_TYPE));
        }

        static public LEFT_TYPE GetValueByRight<LEFT_TYPE, RIGHT_TYPE>(this BidirectionalDictionary<LEFT_TYPE, RIGHT_TYPE> item, RIGHT_TYPE right, LEFT_TYPE default_value)
        {
            LEFT_TYPE left;

            if (item.TryGetValueByRight(right, out left) == false)
                left = default_value;

            return left;
        }
        static public LEFT_TYPE GetValueByRight<LEFT_TYPE, RIGHT_TYPE>(this BidirectionalDictionary<LEFT_TYPE, RIGHT_TYPE> item, RIGHT_TYPE right)
        {
            return item.GetValueByRight(right, default(LEFT_TYPE));
        }
    }
}