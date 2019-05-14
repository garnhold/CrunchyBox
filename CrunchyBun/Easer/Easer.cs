using System;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyBun
{
    public class Easer
    {
        private EaseFunction function;

        private bool is_easing;
        private Timer ease_timer;

        public event MultiProcess<float> OnEase;
        public event MultiProcess OnDone;

        public Easer(EaseFunction f, Timer t)
        {
            function = f;

            is_easing = true;
            ease_timer = t;
        }

        public bool Ease()
        {
            if (is_easing)
            {
                OnEase.InvokeAll(GetCurrentValue());

                if (ease_timer.GetElapsedTimeInSeconds() >= function.GetEndTime())
                    DoDone();
            }

            return is_easing;
        }

        public void DoDone()
        {
            if (is_easing)
                ForceDone();
        }

        public void ForceDone()
        {
            is_easing = false;

            Pause();

            OnDone.InvokeAll();
        }

        public void StopClear()
        {
            is_easing = true;
            ease_timer.StopClear();
        }

        public void Start()
        {
            ease_timer.Start();
        }

        public void Pause()
        {
            ease_timer.Pause();
        }

        public void Restart()
        {
            StopClear();
            Start();
        }

        public float GetCurrentValue()
        {
            return function.Evaluate(ease_timer.GetElapsedTimeInSeconds());
        }
    }
}