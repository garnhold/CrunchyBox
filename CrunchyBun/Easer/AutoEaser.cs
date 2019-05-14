using System;

using CrunchyDough;

namespace CrunchyBun
{
    public class AutoEaser<T> : AutoEaser where T : PeriodicProcess
    {
        public AutoEaser(Easer t, long update_milliseconds) : base(typeof(T), t, update_milliseconds) { }

        public AutoEaser(Easer t) : this(t, 16) { }

        public AutoEaser(EaseFunction f, Timer t) : this(new Easer(f, t)) { }
        public AutoEaser(EaseFunction f) : this(f, new Timer()) { }
    }

    public class AutoEaser
    {
        private Easer easer;
        private PeriodicProcess periodic_process;

        public event MultiProcess<float> OnEase
        {
            add { easer.OnEase += value; }
            remove { easer.OnEase -= value; }
        }

        public event MultiProcess OnDone
        {
            add{ easer.OnDone += value; }
            remove { easer.OnDone -= value; }
        }

        public AutoEaser(Type pt, Easer t, long update_milliseconds)
        {
            easer = t;

            periodic_process = PeriodicProcess.Create(pt, update_milliseconds, delegate() {
                if(easer.Ease() == false)
                    Pause();
            });
        }

        public AutoEaser(Type pt, Easer t) : this(pt, t, 16) { }
        public AutoEaser(Type pt, EaseFunction f, Timer t) : this(pt, new Easer(f, t)) { }
        public AutoEaser(Type pt, EaseFunction f) : this(pt, f, new Timer()) { }

        public void DoDone()
        {
            easer.DoDone();
        }

        public void ForceDone()
        {
            easer.ForceDone();
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
            periodic_process.StopClear();
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