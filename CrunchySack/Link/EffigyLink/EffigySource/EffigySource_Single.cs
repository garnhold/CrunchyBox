using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
    public class EffigySource_Single : EffigySource
    {
        private object transition_value;
        private object incoming_value;

        private VariableInstance variable_instance;

        public EffigySource_Single(VariableInstance v) : base(v)
        {
            variable_instance = v;
        }

        public void Update(Process<object, object> process)
        {
            incoming_value = variable_instance.GetContents();

            if (transition_value.NotEqualsEX(incoming_value))
            {
                process(transition_value, incoming_value);

                Swap.Values(ref transition_value, ref incoming_value);
            }
        }
    }
}