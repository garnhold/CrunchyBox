using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
    public abstract class EffigyInfo
    {
        private Type representation_type;
        private Type child_type;

        public abstract void AddChild(object representation, object child);

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