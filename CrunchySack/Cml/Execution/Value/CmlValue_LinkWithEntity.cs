
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
    
    public class CmlValue_LinkWithEntity : CmlValue
	{
        private CmlValue_Link link;
        private CmlEntity entity;

        public CmlValue_LinkWithEntity(CmlValue_Link l, CmlEntity e)
        {
            link = l;
            entity = e;
        }

        public override CmlScriptValue_Argument CreateScriptArgument()
        {
            return link.CreateScriptArgument();
        }

        public CmlValue_Link GetLink()
        {
            return link;
        }

        public CmlEntity GetEntity()
        {
            return entity;
        }
	}
	
}
