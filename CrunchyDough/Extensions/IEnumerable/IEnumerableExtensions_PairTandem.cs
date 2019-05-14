using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_PairTandem
    {
        static public IEnumerable<OUTPUT_TYPE> PairStrict<OUTPUT_TYPE, INPUT_TYPE1, INPUT_TYPE2>(this IEnumerable<INPUT_TYPE1> item, IEnumerable<INPUT_TYPE2> to_pair, Operation<OUTPUT_TYPE, INPUT_TYPE1, INPUT_TYPE2> operation)
        {
            INPUT_TYPE1 input1;
            INPUT_TYPE2 input2;

            if (item == null)
                item = EmptyEnumerable<INPUT_TYPE1>.INSTANCE;

            if (to_pair == null)
                to_pair = EmptyEnumerable<INPUT_TYPE2>.INSTANCE;

            using (IEnumerator<INPUT_TYPE1> item_enumerator = item.GetEnumerator())
            using (IEnumerator<INPUT_TYPE2> to_pair_enumerator = to_pair.GetEnumerator())
            {
                while (item_enumerator.MoveTandemNextStrict(to_pair_enumerator, out input1, out input2))
                    yield return operation(input1, input2);
            }
        }
        static public IEnumerable<Tuple<INPUT_TYPE1, INPUT_TYPE2>> PairStrict<INPUT_TYPE1, INPUT_TYPE2>(this IEnumerable<INPUT_TYPE1> item, IEnumerable<INPUT_TYPE2> to_pair)
        {
            return item.PairStrict(to_pair, delegate(INPUT_TYPE1 input1, INPUT_TYPE2 input2) {
                return Tuple.New(input1, input2);
            });
        }

        static public IEnumerable<OUTPUT_TYPE> PairPermissive<OUTPUT_TYPE, INPUT_TYPE1, INPUT_TYPE2>(this IEnumerable<INPUT_TYPE1> item, IEnumerable<INPUT_TYPE2> to_pair, Operation<OUTPUT_TYPE, INPUT_TYPE1, INPUT_TYPE2> operation)
        {
            INPUT_TYPE1 input1;
            INPUT_TYPE2 input2;

            if (item == null)
                item = EmptyEnumerable<INPUT_TYPE1>.INSTANCE;

            if (to_pair == null)
                to_pair = EmptyEnumerable<INPUT_TYPE2>.INSTANCE;

            using (IEnumerator<INPUT_TYPE1> item_enumerator = item.GetEnumerator())
            using (IEnumerator<INPUT_TYPE2> to_pair_enumerator = to_pair.GetEnumerator())
            {
                while (item_enumerator.MoveTandemNextPermissive(to_pair_enumerator, out input1, out input2))
                    yield return operation(input1, input2);
            }
        }
        static public IEnumerable<Tuple<INPUT_TYPE1, INPUT_TYPE2>> PairPermissive<INPUT_TYPE1, INPUT_TYPE2>(this IEnumerable<INPUT_TYPE1> item, IEnumerable<INPUT_TYPE2> to_pair)
        {
            return item.PairPermissive(to_pair, delegate(INPUT_TYPE1 input1, INPUT_TYPE2 input2) {
                return Tuple.New(input1, input2);
            });
        }
    }
}