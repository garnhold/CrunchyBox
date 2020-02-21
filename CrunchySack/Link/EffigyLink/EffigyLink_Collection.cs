using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;

    public delegate void EffigyCollectionDestination(EffigyLink link, IList<object> old_values, IList<object> new_values);

    public class EffigyLink_Collection : EffigyLink
    {
        private List<object> transition_values;
        private List<object> incoming_values;

        private VariableInstance variable_instance;
        private EffigyCollectionDestination destination;

        protected override void UpdateInternal()
        {
            incoming_values.Set(variable_instance.GetContents().ToEnumerable<object>());

            if (transition_values.AreElementsEqual(incoming_values) == false)
            {
                destination(this, transition_values, incoming_values);
                Swap.Values(ref transition_values, ref incoming_values);
            }
        }

        public EffigyLink_Collection(CmlContext context, VariableInstance v, EffigyCollectionDestination d, EffigyClassInfo c) : base(context, c)
        {
            transition_values = new List<object>();
            incoming_values = new List<object>();

            variable_instance = v;
            destination = d;
        }

        public override IEnumerable<object> GetValues()
        {
            return transition_values;
        }
    }
}