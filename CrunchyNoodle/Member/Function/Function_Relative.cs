using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Function_Relative : Function
    {
        private Variable target_variable;
        private Function function;

        protected override object ExecuteInternal(object target, params object[] arguments)
        {
            return function.Execute(ResolveTarget(target), arguments);
        }

        protected override string GetFunctionNameInternal()
        {
            return target_variable.ToString(false, false) + "." + function.ToString(false, false, false);
        }

        public Function_Relative(Variable t, Function f) : base(t.GetDeclaringType(), f.GetReturnType(), f.GetParameterTypes())
        {
            target_variable = t;
            function = f;
        }

        public object ResolveTarget(object target)
        {
            return target_variable.GetContents(target);
        }
    }
}