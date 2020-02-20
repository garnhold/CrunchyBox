using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;

    public class VariableValue
    {
        private VariableInstance variable_instance;
        private object value;

        public VariableValue(VariableInstance vi, object v)
        {
            variable_instance = vi;
            value = v;
        }

        public void Initialize()
        {
            variable_instance.SetContents(value);
        }
    }
}