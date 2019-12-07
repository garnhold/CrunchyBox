using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class Variable_Relative : Variable
    {
        private Variable target_variable;
        private Variable variable;

        protected override bool SetContentsInternal(object target, object value)
        {
            return variable.SetContents(ResolveTarget(target), value);
        }

        protected override object GetContentsInternal(object target)
        {
            return variable.GetContents(ResolveTarget(target));
        }

        protected override string GetVariableNameInternal()
        {
            return target_variable.ToString(false, false) + "." + variable.ToString(false, false);
        }

        public Variable_Relative(Variable t, Variable v) : base(t.GetDeclaringType(), v.GetVariableType())
        {
            target_variable = t;
            variable = v;
        }

        public object ResolveTarget(object target)
        {
            return target_variable.GetContents(target);
        }
    }
}