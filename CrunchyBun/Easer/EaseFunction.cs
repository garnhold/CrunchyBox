using System;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyBun
{
    public class EaseFunction
    {
        private float start_time;
        private float end_time;

        private float start_value;
        private float end_value;

        private EaseOperation operation;

        public EaseFunction(float st, float et, float sv, float ev, EaseOperation o)
        {
            start_time = st;
            end_time = et;

            start_value = sv;
            end_value = ev;

            operation = o;
        }

        public EaseFunction(float d, float sv, float ev, EaseOperation o) : this(0.0f, d, sv, ev, o) { }
        public EaseFunction(float d, float ev, EaseOperation o) : this(d, 0.0f, ev, o) { }
        public EaseFunction(float d, EaseOperation o) : this(d, 1.0f, o) { }

        public EaseFunction(float st, Duration d, float sv, float ev, EaseOperation o) : this(st, d.GetSeconds(), sv, ev, o) { }
        public EaseFunction(Duration d, float sv, float ev, EaseOperation o) : this(0.0f, d, sv, ev, o) { }
        public EaseFunction(Duration d, float ev, EaseOperation o) : this(d, 0.0f, ev, o) { }
        public EaseFunction(Duration d, EaseOperation o) : this(d, 1.0f, o) { }

        public float Evaluate(float time)
        {
            return operation.Evaluate(time, start_time, end_time, start_value, end_value);
        }

        public float GetStartTime()
        {
            return start_time;
        }

        public float GetEndTime()
        {
            return end_time;
        }

        public float GetStartValue()
        {
            return start_value;
        }

        public float GetEndValue()
        {
            return end_value;
        }

        public EaseOperation GetOperation()
        {
            return operation;
        }
    }
}