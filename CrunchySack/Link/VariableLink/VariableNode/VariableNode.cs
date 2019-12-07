using System;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class VariableNode
    {
        private object transition_value;

        private VariableInstance variable_instance;

        public VariableNode(VariableInstance v)
        {
            variable_instance = v;
        }

        public bool UpdateState()
        {
            object incoming_value = variable_instance.GetContents();

            if (transition_value.NotEqualsEX(incoming_value))
            {
                transition_value = incoming_value;
                return true;
            }

            return false;
        }

        public bool PushValue(object value)
        {
            if (variable_instance.UpdateContents(value))
            {
                if (UpdateState())
                    return true;
            }

            return false;
        }

        public object GetValue()
        {
            return variable_instance.GetContents();
        }

        public object GetTarget()
        {
            return variable_instance.GetTarget();
        }
    }
}