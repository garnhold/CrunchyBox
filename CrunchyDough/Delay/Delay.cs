using System;

namespace CrunchyDough
{
    public class Delay
    {
        private bool can_fire;
        private Timer timer;

        public Delay(long d, TimeSource t)
        {
            can_fire = false;
            timer = new Timer(d, t);
        }

        public Delay(long d) : this(d, TimeSource_System.INSTANCE) { }

        public Delay(Duration d, TimeSource t) : this(d.GetWholeMilliseconds(), t) { }
        public Delay(Duration d) : this(d.GetWholeMilliseconds()) { }

        public bool Process(Process process)
        {
            if (can_fire)
            {
                if (timer.IsTimeOver())
                {
                    can_fire = false;
                    process();

                    return true;
                }
            }

            return false;
        }

        public void Start()
        {
            timer.Restart();
            can_fire = true;
        }

        public void Cancel()
        {
            timer.StopClear();
            can_fire = false;
        }

        public void SetIntervalInMilliseconds(long milliseconds)
        {
            timer.SetDurationInMilliseconds(milliseconds);
        }

        public long GetIntervalInMilliseconds()
        {
            return timer.GetDurationInMilliseconds();
        }
    }
}