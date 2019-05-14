using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public abstract class ConversionTable<T> : Table<T, T>
    {
        public ConversionTable() : base() { }
        public ConversionTable(IEnumerable<KeyValuePair<T, T>> pairs) : base(pairs) { }
        public ConversionTable(params KeyValuePair<T, T>[] pairs) : base(pairs) { }

        public ConversionTable(IEnumerable<T> pairs)
        {
            Add(pairs);
        }
        public ConversionTable(params T[] pairs)
        {
            Add(pairs);
        }

        public void Add(IEnumerable<T> pairs)
        {
            Add(pairs.PairPermissive().ConvertToKeyValuePairs());
        }
        public void Add(params T[] pairs)
        {
            Add((IEnumerable<T>)pairs);
        }
    }
}