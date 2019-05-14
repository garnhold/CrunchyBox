using System;

using CrunchyDough;

namespace CrunchyBun
{
    public class AutoAffectedValue<VALUE_TYPE, PERIODIC_TYPE> : AutoAffectedValue<VALUE_TYPE> where PERIODIC_TYPE : PeriodicProcess
    {
        public AutoAffectedValue(AffectedValue<VALUE_TYPE> a, long update_milliseconds) : base(typeof(PERIODIC_TYPE), a, update_milliseconds) { }

        public AutoAffectedValue(AffectedValue<VALUE_TYPE> a) : this(a, 16) { }
    }

    public class AutoAffectedValue<VALUE_TYPE>
    {
        private AffectedValue<VALUE_TYPE> affected_value;
        private PeriodicProcess periodic_process;

        public event MultiProcess OnUpdate
        {
            add { affected_value.OnUpdate += value; }
            remove { affected_value.OnUpdate -= value; }
        }

        public event MultiProcess OnDone
        {
            add { affected_value.OnDone += value; }
            remove { affected_value.OnDone -= value; }
        }

        private void PokeProcess()
        {
            affected_value.Start();
            periodic_process.Start();
        }

        private void RestProcess()
        {
            affected_value.Pause();
            periodic_process.StopClear();
        }

        public AutoAffectedValue(Type pt, AffectedValue<VALUE_TYPE> a, long update_milliseconds)
        {
            affected_value = a;

            periodic_process = PeriodicProcess.Create(pt, update_milliseconds, delegate() {
                if (affected_value.Update() == false)
                    RestProcess();
            });

            PokeProcess();
        }

        public AutoAffectedValue(Type pt, AffectedValue<VALUE_TYPE> a) : this(pt, a, 16) { }

        public AffectedValueAffector<VALUE_TYPE> AddAffector(AffectedValueAffector<VALUE_TYPE> a)
        {
            PokeProcess();

            return affected_value.AddAffector(a);
        }

        public AffectedValueAffector<VALUE_TYPE> AddAffector(VALUE_TYPE value, int precedence)
        {
            PokeProcess();

            return affected_value.AddAffector(value, precedence);
        }

        public void RemoveAffector(AffectedValueAffector<VALUE_TYPE> a)
        {
            PokeProcess();

            affected_value.RemoveAffector(a);
        }

        public void DoDone()
        {
            affected_value.DoDone();
            PokeProcess();
        }

        public void ForceDone()
        {
            affected_value.ForceDone();
            PokeProcess();
        }

        public VALUE_TYPE GetCurrentValue()
        {
            return affected_value.GetCurrentValue();
        }

        public VALUE_TYPE GetTargetValue()
        {
            return affected_value.GetTargetValue();
        }
    }
}