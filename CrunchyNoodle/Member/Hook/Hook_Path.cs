using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class Hook_Path : Hook
    {
        private Hook hook;
        private PathResolver path_resolver;

        protected override bool AddDelegateInternal(object target, Delegate @delegate)
        {
            return hook.AddDelegate(path_resolver.ResolveTarget(target), @delegate);
        }

        protected override bool RemoveDelegateInternal(object target, Delegate @delegate)
        {
            return hook.RemoveDelegate(path_resolver.ResolveTarget(target), @delegate);
        }

        protected override string GetHookNameInternal()
        {
            return path_resolver + "." + hook.ToString(false, false);
        }

        protected override IEnumerable<Attribute> GetAllCustomAttributesInternal(bool inherit)
        {
            return hook.GetAllCustomAttributes(inherit);
        }

        public Hook_Path(Hook v, PathResolver p) : base(p.GetInputType(), v.GetHookType())
        {
            hook = v;
            path_resolver = p;
        }
    }
}