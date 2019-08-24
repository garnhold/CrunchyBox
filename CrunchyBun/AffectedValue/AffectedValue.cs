using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyBun
{
    public abstract class AffectedValue<VALUE_TYPE>
    {
        private VALUE_TYPE current_value;
        private VALUE_TYPE rest_value;

        private bool is_active;
        private StepStopwatch step_timer;
        private Timer sleep_timer;

        private List<AffectedValueAffector<VALUE_TYPE>> affectors;

        public event MultiProcess OnUpdate;
        public event MultiProcess OnDone;

        protected abstract VALUE_TYPE CalculateValue(VALUE_TYPE value, VALUE_TYPE target, float delta_time);
        protected abstract bool AreSimiliar(VALUE_TYPE v1, VALUE_TYPE v2);

        private bool UpdateValue(VALUE_TYPE target, float delta_time)
        {
            current_value = CalculateValue(current_value, target, delta_time);

            return AreSimiliar(current_value, target);
        }

        public AffectedValue(VALUE_TYPE r)
        {
            rest_value = r;

            is_active = true;
            step_timer = new StepStopwatch(Duration.Seconds(0.050f)).StartAndGet();
            sleep_timer = new Timer(Duration.Seconds(0.5f));

            affectors = new List<AffectedValueAffector<VALUE_TYPE>>();
        }

        public void WakeUp()
        {
            is_active = true;

            sleep_timer.StopClear();
        }

        public bool Update()
        {
            float delta_time = step_timer.RestartGetSeconds();

            if (is_active && delta_time > 0.0f)
            {
                if (UpdateValue(GetTargetValue(), delta_time))
                {
                    sleep_timer.Start();
                    if (sleep_timer.IsTimeOver())
                        return DoDone();
                }
                else
                {
                    sleep_timer.StopClear();
                }

                OnUpdate.InvokeAll();
            }

            return is_active;
        }

        public AffectedValueAffector<VALUE_TYPE> AddAffector(AffectedValueAffector<VALUE_TYPE> a)
        {
            affectors.Add(a);
            a.Initialize(this);

            WakeUp();
            return a;
        }
        public AffectedValueAffector<VALUE_TYPE> AddAffector(VALUE_TYPE value, int precedence)
        {
            return AddAffector(new AffectedValueAffector<VALUE_TYPE>(value, precedence));
        }

        public void RemoveAffector(AffectedValueAffector<VALUE_TYPE> a)
        {
            affectors.Remove(a);
            a.Initialize(null);

            WakeUp();
        }

        public bool DoDone()
        {
            if (is_active)
                ForceDone();

            return is_active;
        }

        public void ForceDone()
        {
            is_active = false;
            sleep_timer.StopClear();

            current_value = GetTargetValue();

            OnUpdate.InvokeAll();
            OnDone.InvokeAll();
        }

        public void Start()
        {
            step_timer.Start();
        }

        public void Pause()
        {
            step_timer.Pause();
        }

        public VALUE_TYPE GetCurrentValue()
        {
            return current_value;
        }

        public VALUE_TYPE GetTargetValue()
        {
            return affectors.Narrow(a => a.IsEnabled())
                .FindHighestRated(a => a.GetPrecedence())
                .IfNotNull(a => a.GetValue(), rest_value);
        }
    }
}