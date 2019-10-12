using System;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class TargetInstance_Static : TargetInstance
    {
        static public readonly TargetInstance_Static INSTANCE = new TargetInstance_Static();

        private TargetInstance_Static() { }

        public override bool IsAlive()
        {
            return true;
        }

        public override object GetTarget()
        {
            return Variable_Static.TARGET_INSTANCE;
        }

        public override string ToString()
        {
            return "Static";
        }
    }
}