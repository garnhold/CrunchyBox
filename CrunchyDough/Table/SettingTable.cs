using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class SettingTable : ConversionTable<string>
    {
        protected override string PrepareKey(string key) { return key.StyleAsWordInvariant(); }
        protected override string PrepareValue(string value) { return value; }

        public SettingTable() : base() { }
        public SettingTable(IEnumerable<KeyValuePair<string, string>> pairs) : base(pairs) { }
        public SettingTable(params KeyValuePair<string, string>[] pairs) : base(pairs) { }
        public SettingTable(IEnumerable<string> pairs) : base(pairs) { }
        public SettingTable(params string[] pairs) : base(pairs) { }
    }
}