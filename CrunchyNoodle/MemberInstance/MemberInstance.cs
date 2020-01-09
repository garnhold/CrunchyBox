using System;

namespace Crunchy.Noodle
{
    using Dough;
    
    public abstract class MemberInstance
    {
        private TargetInstance target_instance;

        public MemberInstance(TargetInstance t)
        {
            target_instance = t;
        }

        public TargetInstance GetTargetInstance()
        {
            return target_instance;
        }

        public bool IsAlive()
        {
            return target_instance.IsAlive();
        }

        public object GetTarget()
        {
            return target_instance.GetTarget();
        }

        public Type GetTargetType()
        {
            return target_instance.GetTargetType();
        }
    }
}