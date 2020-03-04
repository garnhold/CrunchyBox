using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    public abstract class Hook : Member, IDynamicCustomAttributeProvider
    {
        private Type hook_type;

        protected abstract bool InvokeInternal(object target);

        protected abstract bool AddDelegateInternal(object target, Delegate @delegate);
        protected abstract bool RemoveDelegateInternal(object target, Delegate @delegate);

        protected abstract string GetHookNameInternal();
        protected virtual IEnumerable<Attribute> GetAllCustomAttributesInternal(bool inherit) { return Empty.IEnumerable<Attribute>(); }

        public Hook(Type d, Type h) : base(d)
        {
            hook_type = h;
        }

        public bool Invoke(object target)
        {
            if (target.CanObjectBeTreatedAs(GetDeclaringType()))
                return InvokeInternal(target);

            return false;
        }

        public bool AddDelegate(object target, Delegate @delegate)
        {
            if (target.CanObjectBeTreatedAs(GetDeclaringType()))
                return AddDelegateInternal(target, @delegate);

            return false;
        }

        public bool RemoveDelegate(object target, Delegate @delegate)
        {
            if (target.CanObjectBeTreatedAs(GetDeclaringType()))
                return RemoveDelegateInternal(target, @delegate);

            return false;
        }

        public Type GetHookType()
        {
            return hook_type;
        }

        public string GetHookName()
        {
            return GetHookNameInternal();
        }

        public IEnumerable<Attribute> GetAllCustomAttributes(bool inherit)
        {
            return GetAllCustomAttributesInternal(inherit);
        }

        public string ToString(bool include_declaring_type, bool include_hook_type)
        {
            string to_return = GetHookName();

            if (include_declaring_type)
                to_return = GetDeclaringType() + "::" + to_return;

            if(include_hook_type)
                to_return = GetHookType() + " " + to_return;

            return to_return;
        }

        public override string ToString()
        {
            return ToString(true, true);
        }
    }
}