using System;

using CrunchyDough;

namespace CrunchyNoodle
{
    public abstract class TargetInstance
    {
        public abstract bool IsAlive();
        public abstract object GetTarget();
    }
}