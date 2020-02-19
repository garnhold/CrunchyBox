
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 15 2018 21:52:01 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class CmlValue_Link_WithEntity : CmlValue_Link
	{
        private CmlEntity entity;

        public CmlValue_Link_WithEntity(VariableInstance v, CmlEntity e, HasInfo i) : base(v, i)
        {
            entity = e;
        }

        public override EffigyClassInfo GetClass()
        {
            return new EffigyClassInfo_Static(entity);
        }
	}
	
}
