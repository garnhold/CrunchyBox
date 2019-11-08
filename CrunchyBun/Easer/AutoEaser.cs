using System;

using CrunchyDough;

namespace CrunchyBun
{
    public class AutoEaser<T> : AutoEaser where T : PeriodicProcess
    {
        public AutoEaser(Easer t, long update_milliseconds) : base(typeof(T), t, update_milliseconds) { }
        public AutoEaser(Easer t) : this(t, 16) { }
    }

    public class AutoEaser
    {
        private Easer easer;
        private PeriodicProcess periodic_process;

        public event MultiProcess<float> OnEase;
        public event MultiProcess OnDone;

        public AutoEaser(Type pt, Easer t, long update_milliseconds)
        {
            easer = t;

            periodic_process = PeriodicProcess.Create(pt, update_milliseconds, delegate() {
                if (easer.IsRunning() == false)
                    periodic_process.StopClear();

                OnEase.InvokeAll(easer.GetCurrentValue());

                if (easer.IsTimeOver())
                    DoDone();
            });
        }

        public AutoEaser(Type pt, Easer t) : this(pt, t, 16) { }

        public void DoDone()
        {
            if (easer.IsRunning())
                ForceDone();
        }

        public void ForceDone()
        {
            OnDone.InvokeAll();
            easer.Pause();
        }

        public void StopClear()
        {
            easer.StopClear();
        }

        public void Start()
        {
            easer.Start();
            periodic_process.Start();
        }

        public void Pause()
        {
            easer.Pause();
        }

        public void Restart()
        {
            StopClear();
            Start();
        }

        public float GetCurrentValue()
        {
            return easer.GetCurrentValue();
        }
    }
}