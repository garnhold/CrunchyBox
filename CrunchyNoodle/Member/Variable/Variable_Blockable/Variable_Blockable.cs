using System;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    public class Variable_Blockable : Variable
    {
        private Variable variable;
        private Operation<bool, object> is_settable;

        protected override bool SetContentsInternal(object target, object value)
        {
            if (is_settable(target))
                return variable.SetContents(target, value);

            return false;
        }

        protected override object GetContentsInternal(object target)
        {
            return variable.GetContents(target);
        }

        protected override string GetVariableNameInternal()
        {
            return variable.GetVariableName();
        }

        public Variable_Blockable(Variable v, Operation<bool, object> i) : base(v.GetDeclaringType(), v.GetVariableType())
        {
            variable = v;
            is_settable = i;
        }
    }

    public class Variable_Blockable<DECLARING_TYPE> : Variable_Blockable
    {
        public Variable_Blockable(Variable v, Operation<bool, DECLARING_TYPE> i)
            : base(v,
                delegate(object target) {
                    DECLARING_TYPE cast;

                    if (target.Convert<DECLARING_TYPE>(out cast))
                        return i(cast);

                    return false;
                }
            )
        { }
    }
}