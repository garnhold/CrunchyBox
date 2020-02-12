using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;

    public class CmlSetChildren
    {
        private List<object> children;

        private VariableInstance variable_instance;
        private EffigyClassInfo @class;
        private string group;

        public CmlSetChildren()
        {
            children = new List<object>();
        }

        public void AddChild(object child)
        {
            children.Add(child);
        }

        public void SetLink(VariableInstance v, EffigyClassInfo c, string g)
        {
            variable_instance = v;
            @class = c;
            group = g;
        }

        public VariableInstance GetVariableInstance()
        {
            return variable_instance;
        }

        public EffigyClassInfo GetClass()
        {
            return @class;
        }

        public string GetGroup()
        {
            return group;
        }
    }
}
