using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_PairConsecutive
    {
        static public IEnumerable<OUTPUT_TYPE> PairStrict<OUTPUT_TYPE, INPUT_TYPE>(this IEnumerable<INPUT_TYPE> item, Operation<OUTPUT_TYPE, INPUT_TYPE, INPUT_TYPE> operation)
        {
            INPUT_TYPE input1;
            INPUT_TYPE input2;

            if (item == null)
                item = EmptyEnumerable<INPUT_TYPE>.INSTANCE;

            using (IEnumerator<INPUT_TYPE> enumerator = item.GetEnumerator())
            {
                while (enumerator.MoveConsecutiveNextStrict(out input1, out input2))
                    yield return operation(input1, input2);
            }
        }
        static public IEnumerable<Tuple<T, T>> PairStrict<T>(this IEnumerable<T> item)
        {
            return item.PairStrict(delegate(T input1, T input2) {
                return Tuple.New(input1, input2);
            });
        }

        static public IEnumerable<OUTPUT_TYPE> PairPermissive<OUTPUT_TYPE, INPUT_TYPE>(this IEnumerable<INPUT_TYPE> item, Operation<OUTPUT_TYPE, INPUT_TYPE, INPUT_TYPE> operation)
        {
            INPUT_TYPE input1;
            INPUT_TYPE input2;

            if (item == null)
                item = EmptyEnumerable<INPUT_TYPE>.INSTANCE;

            using (IEnumerator<INPUT_TYPE> enumerator = item.GetEnumerator())
            {
                while (enumerator.MoveConsecutiveNextPermissive(out input1, out input2))
                    yield return operation(input1, input2);
            }
        }
        static public IEnumerable<Tuple<T, T>> PairPermissive<T>(this IEnumerable<T> item)
        {
            return item.PairPermissive(delegate(T input1, T input2) {
                return Tuple.New(input1, input2);
            });
        }
    }
}