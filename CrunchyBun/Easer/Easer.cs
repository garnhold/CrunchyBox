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
        private Stopwatch ease_stopwatch;

        public event MultiProcess<float> OnEase;
        public event MultiProcess OnDone;

        public Easer(EaseFunction f, Stopwatch s)
        {
            function = f;

            is_easing = true;
            ease_stopwatch = s;
        }

        public bool Ease()
        {
            if (is_easing)
            {
                OnEase.InvokeAll(GetCurrentValue());

                if (ease_stopwatch.GetElapsedTimeInSeconds() >= function.GetEndTime())
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
            ease_stopwatch.StopClear();
        }

        public void Start()
        {
            ease_stopwatch.Start();
        }

        public void Pause()
        {
            ease_stopwatch.Pause();
        }

        public void Restart()
        {
            StopClear();
            Start();
        }

        public float GetCurrentValue()
        {
            return function.Evaluate(ease_stopwatch.GetElapsedTimeInSeconds());
        }
    }
}