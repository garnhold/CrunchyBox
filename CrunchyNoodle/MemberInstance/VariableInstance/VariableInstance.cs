using System;

namespace Crunchy.Noodle
{
    public class VariableInstance : MemberInstance
    {
        private Variable variable;

        public VariableInstance(TargetInstance t, Variable v) : base(t)
        {
            variable = v;
        }

        public bool SetContents(object value)
        {
            return variable.SetContents(GetTarget(), value);
        }

        public bool UpdateContents(object value)
        {
            return variable.UpdateContents(GetTarget(), value);
        }

        public object GetContents()
        {
            return variable.GetContents(GetTarget());
        }

        public object PrepareValue(object value)
        {
            return variable.PrepareValue(value);
        }

        public Variable GetVariable()
        {
            return variable;
        }

        public Type GetVariableType()
        {
            return variable.GetVariableType();
        }

        public override string ToString()
        {
            return GetTargetInstance() + " -> " + variable;
        }
    }
}