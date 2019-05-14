using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
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