using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    public class Hook_Evt : Hook
    {
        private EvtInfoEX evt;

        static public Hook_Evt New(Type d, string n)
        {
            return d.GetInstanceEvt(n).IfNotNull(e => new Hook_Evt(e));
        }

        protected override bool InvokeInternal(object target)
        {
            if (evt.CanInvoke())
            {
                evt.Invoke(target);

                return true;
            }

            return false;
        }

        protected override bool AddDelegateInternal(object target, Delegate @delegate)
        {
            if (evt.CanAdd())
            {
                evt.AddDelegate(target, @delegate);

                return true;
            }

            return false;
        }

        protected override bool RemoveDelegateInternal(object target, Delegate @delegate)
        {
            if (evt.CanRemove())
            {
                evt.RemoveDelegate(target, @delegate);

                return true;
            }

            return false;
        }

        protected override string GetHookNameInternal()
        {
            return evt.GetName();
        }

        protected override IEnumerable<Attribute> GetAllCustomAttributesInternal(bool inherit)
        {
            return evt.GetAllCustomAttributes(inherit);
        }

        public Hook_Evt(EvtInfoEX e) : base(e.GetDeclaringType(), e.GetEvtType())
        {
            evt = e;
        }
    }
}