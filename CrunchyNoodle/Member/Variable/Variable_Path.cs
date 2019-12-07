using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class Variable_Path : Variable
    {
        private Variable variable;
        private PathResolver path_resolver;

        protected override bool SetContentsInternal(object target, object value)
        {
            return variable.SetContents(path_resolver.ResolveTarget(target), value);
        }

        protected override object GetContentsInternal(object target)
        {
            return variable.GetContents(path_resolver.ResolveTarget(target));
        }

        protected override string GetVariableNameInternal()
        {
            return path_resolver + "." + variable.ToString(false, false);
        }

        public Variable_Path(Variable v, PathResolver p) : base(p.GetInputType(), v.GetVariableType())
        {
            variable = v;
            path_resolver = p;
        }
    }
}