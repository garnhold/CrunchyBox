using System;

namespace Crunchy.Sack
{
    using System.Collections.Generic;
    using Dough;
    using Noodle;

    public delegate void EffigySingleDestination(EffigyLink link, object old_value, object new_value);

    public class EffigyLink_Single : EffigyLink
    {
        private object transition_value;
        private object incoming_value;

        private VariableInstance variable_instance;
        private EffigySingleDestination destination;

        protected override void UpdateInternal()
        {
            incoming_value = variable_instance.GetContents();

            if (transition_value.NotEqualsEX(incoming_value))
            {
                destination(this, transition_value, incoming_value);

                Swap.Values(ref transition_value, ref incoming_value);
            }
        }

        public EffigyLink_Single(CmlContext context, VariableInstance v, EffigySingleDestination d, EffigyClassInfo c) : base(context, c)
        {
            variable_instance = v;
            destination = d;
        }

        public override IEnumerable<object> GetValues()
        {
            yield return transition_value;
        }
    }
}