using System;

namespace Crunchy.Dough
{
    public abstract class PeriodicProcess
    {
        private Process process;

        public abstract void Start();
        public abstract void StopClear();

        static public PeriodicProcess Create(Type type, long milliseconds, Process process)
        {
            if(type.CanBeTreatedAs<PeriodicProcess>())
                return type.CreateInstance<PeriodicProcess>(milliseconds, process);

            return null;
        }

        protected void ExecuteProcess()
        {
            process();
        }

        public PeriodicProcess(Process p)
        {
            SetProcess(p);
        }

        public PeriodicProcess() : this(null) { }

        public void Step()
        {
            ExecuteProcess();
        }

        public void SetProcess(Process p)
        {
            process = p;
        }

        public Process GetProcess()
        {
            return process;
        }
    }
}