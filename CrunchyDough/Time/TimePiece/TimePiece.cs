using System;
using System.Reflection;

namespace CrunchyDough
{
    public abstract class TimePiece
    {
        public abstract bool Start();
        public abstract bool Pause();

        public abstract void SetElapsedTimeInMilliseconds(long m);

        public abstract bool IsRunning();
        public abstract long GetElapsedTimeInMilliseconds();
    }
}