using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class EffigyClassInfo_Dynamic : EffigyClassInfo
    {
        private string layout;

        public EffigyClassInfo_Dynamic(string l)
        {
            layout = l;
        }

        public override CmlEntry_Class AssertGetClass(CmlExecution execution)
        {
            if (layout == "none")
                return new CmlEntry_Class_None(execution.GetTargetInfo().GetTargetType());

            return execution.GetTargetInfo().GetEngine().GetClassLibrary()
                .AssertGetClass(execution.GetTargetInfo().GetTargetType(), layout);
        }
    }
}