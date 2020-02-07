using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class EffigySource_Collection : EffigySource
    {
        private List<object> transition_values;
        private List<object> incoming_values;

        private VariableInstance variable_instance;

        public EffigySource_Collection(VariableInstance v) : base(v)
        {
            transition_values = new List<object>();
            incoming_values = new List<object>();

            variable_instance = v;
        }

        public void Update(Process<List<object>, List<object>> process)
        {
            incoming_values.Set(variable_instance.GetContents().ToEnumerable<object>());

            if (transition_values.AreElementsEqual(incoming_values) == false)
            {
                process(transition_values, incoming_values);
                Swap.Values(ref transition_values, ref incoming_values);
            }
        }

        public override IEnumerable<object> GetValues()
        {
            return transition_values;
        }
    }
}