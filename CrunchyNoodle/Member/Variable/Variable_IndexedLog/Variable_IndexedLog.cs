using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Variable_IndexedLog : Variable
    {
        private SortedList<int, object> values;

        static public Variable_IndexedLog New(Type type)
        {
            return new Variable_IndexedLog(type);
        }

        protected override bool SetContentsInternal(object target, object value)
        {
            values[(int)target] = value;

            return true;
        }

        protected override object GetContentsInternal(object target)
        {
            object value;

            values.TryGetValue((int)target, out value);
            return value;
        }

        protected override string GetVariableNameInternal()
        {
            return "indexed_log";
        }

        public Variable_IndexedLog(Type t) : base(typeof(int), t)
        {
            values = new SortedList<int, object>();
        }

        public void Clear()
        {
            values.Clear();
        }

        public IEnumerable<object> GetValues()
        {
            return values.Values;
        }
    }
}