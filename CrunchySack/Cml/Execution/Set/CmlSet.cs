using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;

    public class CmlSet
    {
        private Dictionary<string, CmlSetMember> members;

        public CmlSet()
        {
            members = new Dictionary<string, CmlSetMember>();
        }

        public void SetValue(string name, object value)
        {
            members.GetOrCreateDefaultValue(name).SetValue(value);
        }

        public void LinkValue(string name, VariableInstance variable_instance, HasInfo info)
        {
            members.GetOrCreateDefaultValue(name).LinkValue(variable_instance, info);
        }

        public void LinkValueWithEntity(string name, VariableInstance variable_instance, CmlEntity entity, HasInfo info)
        {
            members.GetOrCreateDefaultValue(name).LinkValueWithEntity(variable_instance, entity, info);
        }

        public CmlSetMember GetMember(string name)
        {
            return members.GetValue(name);
        }
    }
}
