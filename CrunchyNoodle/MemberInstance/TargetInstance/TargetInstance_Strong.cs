using System;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class TargetInstance_Strong : TargetInstance
    {
        private object target;

        public TargetInstance_Strong(object t)
        {
            target = t;
        }

        public override bool IsAlive()
        {
            return true;
        }

        public override object GetTarget()
        {
            return target;
        }

        public override string ToString()
        {
            return "Strong(" + GetTarget() + ")";
        }
    }
}