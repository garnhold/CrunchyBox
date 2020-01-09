using System;

namespace Crunchy.Noodle
{
    using Dough;
    
    public abstract class TargetInstance
    {
        public abstract bool IsAlive();
        public abstract object GetTarget();
    }
}