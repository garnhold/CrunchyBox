using System;

namespace Crunchy.Noodle
{
    using Dough;

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

        public ValueChangeResult ChangeContents(object value)
        {
            return variable.ChangeContents(GetTarget(), value);
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