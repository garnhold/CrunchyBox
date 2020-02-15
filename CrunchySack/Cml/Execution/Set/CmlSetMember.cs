using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;

    public class CmlSetMember
    {
        private List<object> values;

        private VariableInstance variable_instance;
        private CmlEntity entity;
        private HasInfo info;

        public CmlSetMember()
        {
            values = new List<object>();
        }

        public void SetValue(object v)
        {
            values.Add(v);
        }

        public void LinkValue(VariableInstance v, HasInfo i)
        {
            variable_instance = v;
            info = i;
        }

        public void LinkValueWithEntity(VariableInstance v, CmlEntity e, HasInfo i)
        {
            variable_instance = v;
            entity = e;
            info = i;
        }

        public IEnumerable<object> GetValues()
        {
            return values;
        }

        public VariableInstance GetVariableInstance()
        {
            return variable_instance;
        }

        public string GetGroup()
        {
            return info.GetInfoValue("group");
        }

        public EffigyClassInfo GetClass()
        {
            if (entity != null)
                return new EffigyClassInfo_Static(entity);

            return new EffigyClassInfo_Dynamic(info.GetInfoValue("layout"));
        }
    }
}
