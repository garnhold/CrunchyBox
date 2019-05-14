using System;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class TargetInstance_Weak : TargetInstance
    {
        private WeakReference target;

        public TargetInstance_Weak(object t)
        {
            target = new WeakReference(t);
        }

        public override bool IsAlive()
        {
            if (target.IsAlive())
                return true;

            return false;
        }

        public override object GetTarget()
        {
            return target.Get();
        }

        public override string ToString()
        {
            return "Weak(" + GetTarget() + ")";
        }
    }
}