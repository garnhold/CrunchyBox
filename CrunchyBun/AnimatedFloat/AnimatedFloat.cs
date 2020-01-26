using System;

namespace Crunchy.Bun
{
    using Dough;
    
    public class AnimatedFloat
    {
        private float current_value;
        private float target_value;

        private AnimateOperation operation;
        private StepStopwatch step_timer;

        private bool is_animating;
        private Timer sleep_timer;

        public event MultiProcess OnAnimate;
        public event MultiProcess OnDone;

        public AnimatedFloat(AnimateOperation o)
        {
            operation = o;
            step_timer = new StepStopwatch(Duration.Seconds(0.050f)).Chain(z => z.Start());

            is_animating = true;
            sleep_timer = new Timer(Duration.Seconds(0.5f));
        }

        public bool Animate()
        {
            float delta_time = step_timer.RestartGetSeconds();

            if (is_animating && delta_time > 0.0f)
            {
                current_value = operation(current_value, target_value, delta_time);
                if (current_value.IsApproximatelyEqual(target_value))
                {
                    sleep_timer.Start();
                    if (sleep_timer.IsTimeOver())
                        return DoDone();
                }
                else
                {
                    sleep_timer.StopClear();
                }

                OnAnimate.InvokeAll();
            }

            return is_animating;
        }

        public bool DoDone()
        {
            if (is_animating)
                ForceDone();

            return is_animating;
        }

        public void ForceDone()
        {
            is_animating = false;
            sleep_timer.StopClear();

            current_value = target_value;

            OnAnimate.InvokeAll();
            OnDone.InvokeAll();
        }

        public bool SetValue(float v)
        {
            if (v != target_value)
            {
                is_animating = true;
                target_value = v;

                return true;
            }

            return false;
        }

        public bool ForceValue(float v)
        {
            if (SetValue(v))
            {
                DoDone();
                return true;
            }

            return false;
        }

        public void Start()
        {
            step_timer.Start();
        }

        public void Pause()
        {
            step_timer.Pause();
        }

        public float GetCurrentValue()
        {
            return current_value;
        }

        public float GetTargetValue()
        {
            return target_value;
        }
    }
}