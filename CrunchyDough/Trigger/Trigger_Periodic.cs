using System;

namespace CrunchyDough
{
    public abstract class Trigger_Periodic : Trigger
    {
        [StateField]private Timer_Duration timer;

        protected abstract long CalculateIntervalInMilliseconds();

        public Trigger_Periodic(TimeSource t)
        {
            timer = new Timer_Duration(CalculateIntervalInMilliseconds(), t);
        }

        public override bool Check()
        {
            if(timer.Repeat())
            {
                timer.SetDurationInMilliseconds(CalculateIntervalInMilliseconds());

                return true;
            }

            return false;
        }

        public override bool Start()
        {
            return timer.Start();
        }

        public override bool Pause()
        {
            return timer.Pause();
        }

        public override bool IsRunning()
        {
            return timer.IsRunning();
        }
    }
}