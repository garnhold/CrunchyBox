using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;

    public abstract class VariableValue
    {
        private object representation;
        private object value;

        protected abstract void Push(object representation, object value);

        public VariableValue(object r, object v)
        {
            representation = r;
            value = v;
        }

        public void Initialize()
        {
            Push(representation, value);
        }
    }
}