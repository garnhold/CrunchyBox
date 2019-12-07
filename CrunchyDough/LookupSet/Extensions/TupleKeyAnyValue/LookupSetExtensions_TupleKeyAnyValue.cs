using System;

namespace Crunchy.Dough
{
    static public class LookupSetExtensions_TupleKeyAnyValue
    {
        static public bool TryLookup<P1, P2, VALUE_TYPE>(this LookupSet<Tuple<P1, P2>, VALUE_TYPE> item, P1 p1, P2 p2, out VALUE_TYPE value)
        {
            return item.TryLookup(Tuple.New(p1, p2), out value);
        }
        static public VALUE_TYPE Lookup<P1, P2, VALUE_TYPE>(this LookupSet<Tuple<P1, P2>, VALUE_TYPE> item, P1 p1, P2 p2)
        {
            VALUE_TYPE value;

            item.TryLookup(p1, p2, out value);
            return value;
        }

        static public bool TryLookup<P1, P2, P3, VALUE_TYPE>(this LookupSet<Tuple<P1, P2, P3>, VALUE_TYPE> item, P1 p1, P2 p2, P3 p3, out VALUE_TYPE value)
        {
            return item.TryLookup(Tuple.New(p1, p2, p3), out value);
        }
        static public VALUE_TYPE Lookup<P1, P2, P3, VALUE_TYPE>(this LookupSet<Tuple<P1, P2, P3>, VALUE_TYPE> item, P1 p1, P2 p2, P3 p3)
        {
            VALUE_TYPE value;

            item.TryLookup(p1, p2, p3, out value);
            return value;
        }

        static public bool TryLookup<P1, P2, P3, P4, VALUE_TYPE>(this LookupSet<Tuple<P1, P2, P3, P4>, VALUE_TYPE> item, P1 p1, P2 p2, P3 p3, P4 p4, out VALUE_TYPE value)
        {
            return item.TryLookup(Tuple.New(p1, p2, p3, p4), out value);
        }
        static public VALUE_TYPE Lookup<P1, P2, P3, P4, VALUE_TYPE>(this LookupSet<Tuple<P1, P2, P3, P4>, VALUE_TYPE> item, P1 p1, P2 p2, P3 p3, P4 p4)
        {
            VALUE_TYPE value;

            item.TryLookup(p1, p2, p3, p4, out value);
            return value;
        }
    }
}