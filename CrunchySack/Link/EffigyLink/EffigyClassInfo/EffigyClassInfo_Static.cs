using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class EffigyClassInfo_Static : EffigyClassInfo
    {
        private CmlEntity entity;

        public EffigyClassInfo_Static(CmlEntity e)
        {
            entity = e;
        }

        public override CmlClass AssertGetClass(CmlContext context)
        {
            return new CmlClass_Entity(context.GetTargetInfo().GetTargetType(), "<inline>", entity);
        }
    }
}