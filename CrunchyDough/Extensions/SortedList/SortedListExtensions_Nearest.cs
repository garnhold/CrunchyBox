using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class SortedListExtensions_Nearest
    {
        static public bool TryFindNearestIndexByKey<KEY_TYPE, VALUE_TYPE>(this SortedList<KEY_TYPE, VALUE_TYPE> item, KEY_TYPE target_key, out int index, BoundType bound_type) where KEY_TYPE : IComparable<KEY_TYPE>
        {
            int lower_index = 0;
            int upper_index = item.GetFinalIndex();

            index = lower_index;
            switch (target_key.CompareToEX(item.Keys[lower_index]))
            {
                case CompareResult.LessThan: return bound_type.ConvertBoundType(false, true);
                case CompareResult.EqualTo: return true;
            }

            index = upper_index;
            switch(target_key.CompareToEX(item.Keys[upper_index]))
            {
                case CompareResult.GreaterThan: return bound_type.ConvertBoundType(true, false);
                case CompareResult.EqualTo: return true;
            }

            while (upper_index - lower_index > 1)
            {
                index = (lower_index + upper_index) / 2;

                switch(target_key.CompareToEX(item.Keys[index]))
                {
                    case CompareResult.LessThan:
                        upper_index = index;
                        break;

                    case CompareResult.GreaterThan:
                        lower_index = index;
                        break;

                    case CompareResult.EqualTo:
                        return true;
                }
            }

            index = bound_type.ConvertBoundType(lower_index, upper_index);
            return true;
        }
        static public int FindNearestIndexByKey<KEY_TYPE, VALUE_TYPE>(this SortedList<KEY_TYPE, VALUE_TYPE> item, KEY_TYPE target_key, BoundType bound_type) where KEY_TYPE : IComparable<KEY_TYPE>
        {
            int index;

            item.TryFindNearestIndexByKey(target_key, out index, bound_type);
            return index;
        }

        static public bool TryFindNearestKeyByKey<KEY_TYPE, VALUE_TYPE>(this SortedList<KEY_TYPE, VALUE_TYPE> item, KEY_TYPE target_key, out KEY_TYPE output, BoundType bound_type) where KEY_TYPE : IComparable<KEY_TYPE>
        {
            int index;

            if (item.TryFindNearestIndexByKey(target_key, out index, bound_type))
            {
                output = item.Keys[index];
                return true;
            }

            output = default(KEY_TYPE);
            return false;
        }
        static public KEY_TYPE FindNearestKeyByKey<KEY_TYPE, VALUE_TYPE>(this SortedList<KEY_TYPE, VALUE_TYPE> item, KEY_TYPE target_key, BoundType bound_type) where KEY_TYPE : IComparable<KEY_TYPE>
        {
            KEY_TYPE output;

            item.TryFindNearestKeyByKey(target_key, out output, bound_type);
            return output;
        }

        static public bool TryFindNearestValueByKey<KEY_TYPE, VALUE_TYPE>(this SortedList<KEY_TYPE, VALUE_TYPE> item, KEY_TYPE target_key, out VALUE_TYPE output, BoundType bound_type) where KEY_TYPE : IComparable<KEY_TYPE>
        {
            int index;
            
            if(item.TryFindNearestIndexByKey(target_key, out index, bound_type))
            {
                output = item.Values[index];
                return true;
            }

            output = default(VALUE_TYPE);
            return false;
        }
        static public VALUE_TYPE FindNearestValueByKey<KEY_TYPE, VALUE_TYPE>(this SortedList<KEY_TYPE, VALUE_TYPE> item, KEY_TYPE target_key, BoundType bound_type) where KEY_TYPE : IComparable<KEY_TYPE>
        {
            VALUE_TYPE output;

            item.TryFindNearestValueByKey(target_key, out output, bound_type);
            return output;
        }
    }
}