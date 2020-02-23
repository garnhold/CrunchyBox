
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 13 2018 22:31:32 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public abstract class CmlClass
	{
        private Type target_type;
        private string layout;

        protected abstract object InstanceInternal(CmlContext context);

        public CmlClass(Type t, string l)
        {
            target_type = t;
            layout = l;
        }

        public object Instance(CmlContext context)
        {
            return InstanceInternal(
                context
                    .NewUnitSpace()
                    .NewClass(this)
            );
        }

        public Type GetTargetType()
        {
            return target_type;
        }

        public string GetLayout()
        {
            return layout;
        }
	}
	
}
