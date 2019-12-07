using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class OptionTable<T> : Table<string, T>
    {
        protected override string PrepareKey(string key) { return key.StyleAsWordInvariant(); }
        protected override T PrepareValue(T value) { return value; }

        public OptionTable() : base() { }
        public OptionTable(IEnumerable<KeyValuePair<string, T>> pairs) : base(pairs) { }
        public OptionTable(params KeyValuePair<string, T>[] pairs) : base(pairs) { }
    }
}