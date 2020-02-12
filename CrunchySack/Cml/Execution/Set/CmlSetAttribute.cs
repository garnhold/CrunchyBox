using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;

    public class CmlSetAttribute
    {
        private object value;

        private VariableInstance variable_instance;
        private string group;

        public CmlSetAttribute()
        {
        }

        public void SetValue(object v)
        {
            value = v;
        }

        public void SetLink(VariableInstance v, string g)
        {
            variable_instance = v;
            group = g;
        }

        public object GetValue()
        {
            return value;
        }

        public VariableInstance GetVariableInstance()
        {
            return variable_instance;
        }

        public string GetGroup()
        {
            return group;
        }
    }
}
