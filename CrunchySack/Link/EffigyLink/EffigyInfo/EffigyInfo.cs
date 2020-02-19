using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public abstract class EffigyInfo
    {
        private Type representation_type;
        private Type child_type;

        public abstract void SetChildren(object representation, IEnumerable<object> children);
        public abstract EffigyLink CreateLink(CmlContext context, object representation, VariableInstance variable_instance, EffigyClassInfo @class);

        public EffigyInfo(Type r, Type c)
        {
            representation_type = r;
            child_type = c;
        }

        public Type GetRepresentationType()
        {
            return representation_type;
        }

        public Type GetChildType()
        {
            return child_type;
        }
    }
}