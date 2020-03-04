using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    public class Hook_Operation : Hook
    {
        private string name;

        private Process<object> invoke;
        private Process<object, Delegate> add;
        private Process<object, Delegate> remove;

        protected override bool InvokeInternal(object target)
        {
            if (invoke != null)
            {
                invoke(target);

                return true;
            }

            return false;
        }

        protected override bool AddDelegateInternal(object target, Delegate @delegate)
        {
            if (add != null)
            {
                add(target, @delegate);

                return true;
            }

            return false;
        }

        protected override bool RemoveDelegateInternal(object target, Delegate @delegate)
        {
            if (remove != null)
            {
                remove(target, @delegate);

                return true;
            }

            return false;
        }

        protected override string GetHookNameInternal()
        {
            return name;
        }

        public Hook_Operation(Type d, Type h, string n, Process<object> i, Process<object, Delegate> a, Process<object, Delegate> r) : base(d, h)
        {
            name = n;

            invoke = i;
            add = a;
            remove = r;
        }
    }

    public class Hook_Operation<DECLARING_TYPE, HOOK_TYPE> : Hook_Operation
    {
        public Hook_Operation(string n, Process<DECLARING_TYPE> i, Process<DECLARING_TYPE, HOOK_TYPE> a, Process<DECLARING_TYPE, HOOK_TYPE> r)
            : base(typeof(DECLARING_TYPE), typeof(HOOK_TYPE), n,
                i.IfNotNull(z => (Process<object>)delegate (object obj) {
                    z((DECLARING_TYPE)obj);
                }),
                a.IfNotNull(z => (Process<object, Delegate>)delegate (object obj, Delegate @delegate) {
                    z((DECLARING_TYPE)obj, @delegate.Convert<HOOK_TYPE>());
                }),
                r.IfNotNull(z => (Process<object, Delegate>)delegate (object obj, Delegate @delegate) {
                    z((DECLARING_TYPE)obj, @delegate.Convert<HOOK_TYPE>());
                })
            ) { }
    }
}