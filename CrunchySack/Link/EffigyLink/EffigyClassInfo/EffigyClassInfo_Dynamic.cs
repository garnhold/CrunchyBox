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

        public override CmlClass AssertGetClass(CmlContext context)
        {
            if (layout == "none")
                return new CmlClass_None(context.GetTargetInfo().GetTargetType());

            return context.GetEngine().GetClassLibrary()
                .AssertGetClass(context.GetTargetInfo().GetTargetType(), layout);
        }
    }
}