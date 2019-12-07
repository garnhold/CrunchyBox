using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    public abstract class Action : Member, IDynamicCustomAttributeProvider
    {
        protected abstract void ExecuteInternal(object target);

        protected abstract string GetActionNameInternal();

        protected virtual IEnumerable<Attribute> GetAllCustomAttributesInternal(bool inherit) { return Empty.IEnumerable<Attribute>(); }

        public Action(Type d) : base(d)
        {
        }

        public void Execute(object target)
        {
            if (target != null)
                ExecuteInternal(target);
        }

        public string GetActionName()
        {
            return GetActionNameInternal();
        }

        public IEnumerable<Attribute> GetAllCustomAttributes(bool inherit)
        {
            return GetAllCustomAttributesInternal(inherit);
        }

        public string ToString(bool include_declaring_type)
        {
            string to_return = GetActionName();

            if (include_declaring_type)
                to_return = GetDeclaringType() + "::" + to_return;

            return to_return;
        }

        public override string ToString()
        {
            return ToString(true);
        }
    }
}