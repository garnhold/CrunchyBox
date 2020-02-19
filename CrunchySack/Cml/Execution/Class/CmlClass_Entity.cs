
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
    
    public class CmlClass_Entity : CmlClass
	{
        private CmlEntity entity;

        protected override object InstanceInternal(CmlContext context)
        {
            return entity.Instance(context);
        }

        public CmlClass_Entity(Type t, string l, CmlEntity e) : base(t, l)
        {
            entity = e;
        }
	}
	
}
