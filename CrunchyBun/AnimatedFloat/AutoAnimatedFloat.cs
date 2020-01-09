using System;

namespace Crunchy.Bun
{
    using Dough;
    
    public class AutoAnimatedFloat<T> : AutoAnimatedFloat where T : PeriodicProcess
    {
        public AutoAnimatedFloat(AnimatedFloat a, long update_milliseconds) : base(typeof(T), a, update_milliseconds) { }

        public AutoAnimatedFloat(AnimatedFloat a) : this(a, 16) { }
        public AutoAnimatedFloat(AnimateOperation o) : this(new AnimatedFloat(o)) { }
    }

    public class AutoAnimatedFloat
    {
        private AnimatedFloat animated_float;
        private PeriodicProcess periodic_process;

        public event MultiProcess OnAnimate
        {
            add { animated_float.OnAnimate += value; }
            remove { animated_float.OnAnimate -= value; }
        }

        public event MultiProcess OnDone
        {
            add { animated_float.OnDone += value; }
            remove { animated_float.OnDone -= value; }
        }

        private void PokeProcess()
        {
            animated_float.Start();
            periodic_process.Start();
        }

        private void RestProcess()
        {
            animated_float.Pause();
            periodic_process.StopClear();
        }

        public AutoAnimatedFloat(Type pt, AnimatedFloat a, long update_milliseconds)
        {
            animated_float = a;

            periodic_process = PeriodicProcess.Create(pt, update_milliseconds, delegate() {
                if (animated_float.Animate() == false)
                    RestProcess();
            });

            PokeProcess();
        }

        public AutoAnimatedFloat(Type pt, AnimatedFloat a) : this(pt, a, 16) { }
        public AutoAnimatedFloat(Type pt, AnimateOperation o) : this(pt, new AnimatedFloat(o)) { }

        public void DoDone()
        {
            animated_float.DoDone();
            PokeProcess();
        }

        public void ForceDone()
        {
            animated_float.ForceDone();
            PokeProcess();
        }

        public void SetValue(float v)
        {
            if (animated_float.SetValue(v))
                PokeProcess();
        }

        public void ForceValue(float v)
        {
            if (animated_float.ForceValue(v))
                PokeProcess();
        }

        public float GetCurrentValue()
        {
            return animated_float.GetCurrentValue();
        }

        public float GetTargetValue()
        {
            return animated_float.GetTargetValue();
        }
    }
}