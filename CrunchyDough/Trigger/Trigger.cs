using System;

namespace CrunchyDough
{
    public abstract class Trigger : Temporal
    {
        public abstract bool Start();
        public abstract bool Pause();

        public abstract bool IsRunning();

        public abstract bool Check();
    }
}