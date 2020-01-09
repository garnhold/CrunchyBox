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

        public override CmlEntry_Class AssertGetClass(CmlExecution execution)
        {
            return new CmlEntry_Class_Entity(execution.GetTargetInfo().GetTargetType(), "<inline>", entity);
        }
    }
}