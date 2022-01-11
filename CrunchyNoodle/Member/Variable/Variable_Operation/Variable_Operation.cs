using System;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    public class Variable_Operation : Variable
    {
        private string name;

        private Process<object, object> set;
        private Operation<object, object> get;

        protected override bool SetContentsInternal(object target, object value)
        {
            if (set != null)
            {
                set(target, value);

                return true;
            }

            return false;
        }
        protected override ILStatement CompileSetContentsInternal(ILValue target, ILValue value)
        {
            if (set != null)
                return set.GetILDelegateInvokation(target, value);

            return null;
        }

        protected override object GetContentsInternal(object target)
        {
            if(get != null)
                return get(target);

            return null;
        }
        protected override ILValue CompileGetContentsInternal(ILValue target)
        {
            if (get != null)
                return get.GetILDelegateInvokation(target);

            return null;
        }

        protected override string GetVariableNameInternal()
        {
            return name;
        }

        public Variable_Operation(Type d, Type v, string n, Process<object, object> s, Operation<object, object> g) : base(d, v)
        {
            name = n;

            set = s;
            get = g;
        }
    }

    public class Variable_Operation<DECLARING_TYPE, VARIABLE_TYPE> : Variable_Operation
    {
        public Variable_Operation(string n, Process<DECLARING_TYPE, VARIABLE_TYPE> s, Operation<VARIABLE_TYPE, DECLARING_TYPE> g)
            : base(typeof(DECLARING_TYPE), typeof(VARIABLE_TYPE), n,
                s.IfNotNull(z => (Process<object, object>)delegate(object target, object value) {
                    z((DECLARING_TYPE)target, (VARIABLE_TYPE)value);
                }),
                g.IfNotNull(z => (Operation<object, object>)delegate(object target) {
                    return z((DECLARING_TYPE)target);
                })
            ) { }
    }
}