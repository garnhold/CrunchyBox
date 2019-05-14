using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class IndexedTable<T> : Table<int, T>
    {
        protected override int PrepareKey(int key) { return key; }
        protected override T PrepareValue(T value) { return value; }

        public IndexedTable() : base() { }
        public IndexedTable(IEnumerable<KeyValuePair<int, T>> pairs) : base(pairs) { }
        public IndexedTable(params KeyValuePair<int, T>[] pairs) : base(pairs) { }
    }
}