using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public abstract class StaticEffigyInfo
    {
        private Type representation_type;
        private Type child_type;

        public abstract void AddChild(object representation, object child);

        public StaticEffigyInfo(Type r, Type c)
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