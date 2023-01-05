using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_To_BidirectionalDictionary
    {
        static public BidirectionalDictionary<LEFT_TYPE, RIGHT_TYPE> ToBidirectionalDictionary<LEFT_TYPE, RIGHT_TYPE>(this IEnumerable<KeyValuePair<LEFT_TYPE, RIGHT_TYPE>> item)
        {
            return new BidirectionalDictionary<LEFT_TYPE, RIGHT_TYPE>(item);
        }
        static public BidirectionalDictionary<LEFT_TYPE, RIGHT_TYPE> ToBidirectionalDictionary<LEFT_TYPE, RIGHT_TYPE>(this IEnumerable<Tuple<LEFT_TYPE, RIGHT_TYPE>> item)
        {
            return new BidirectionalDictionary<LEFT_TYPE, RIGHT_TYPE>(item.ConvertToKeyValuePairs());
        }
    }
}