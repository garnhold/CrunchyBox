using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class Function_Path : Function
    {
        private Function function;
        private PathResolver path_resolver;

        protected override object ExecuteInternal(object target, params object[] arguments)
        {
            return function.Execute(path_resolver.ResolveTarget(target), arguments);
        }

        protected override string GetFunctionNameInternal()
        {
            return path_resolver + "." + function.ToString(false, false, true);
        }

        public Function_Path(Function f, PathResolver p) : base(p.GetInputType(), f.GetReturnType(), f.GetParameters())
        {
            function = f;
            path_resolver = p;
        }
    }
}