using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class LabeledTable<T> : Table<string, T>
    {
        protected override string PrepareKey(string key) { return key; }
        protected override T PrepareValue(T value) { return value; }

        public LabeledTable() : base() { }
        public LabeledTable(IEnumerable<KeyValuePair<string, T>> pairs) : base(pairs) { }
        public LabeledTable(params KeyValuePair<string, T>[] pairs) : base(pairs) { }
    }
}