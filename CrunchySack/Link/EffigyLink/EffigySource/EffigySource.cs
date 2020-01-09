using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public abstract class EffigySource
    {
        MemberInstance member_instance;

        public EffigySource(MemberInstance i)
        {
            member_instance = i;
        }

        public object GetTarget()
        {
            return member_instance.GetTarget();
        }
    }
}