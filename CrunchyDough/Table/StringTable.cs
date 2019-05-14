using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class StringTable : ConversionTable<string>
    {
        protected override string PrepareKey(string key) { return key; }
        protected override string PrepareValue(string value) { return value; }

        public StringTable() : base() { }
        public StringTable(IEnumerable<KeyValuePair<string, string>> pairs) : base(pairs) { }
        public StringTable(params KeyValuePair<string, string>[] pairs) : base(pairs) { }
        public StringTable(IEnumerable<string> pairs) : base(pairs) { }
        public StringTable(params string[] pairs) : base(pairs) { }
    }
}