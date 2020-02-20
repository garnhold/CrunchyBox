
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 16 2018 12:44:50 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class CmlFragment_Entity : CmlFragment
	{
        private string name;
        private CmlEntity entity;

        protected override object InstanceInternal(CmlContext context)
        {
            return entity.Instance(context);
        }

        public CmlFragment_Entity(string n, CmlEntity e)
        {
            name = n;
            entity = e;
        }

        public override string GetName()
        {
            return name;
        }
	}
	
}
