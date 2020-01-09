using System;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    public class Variable_Operation : Variable
    {
        private string name;

        private TryProcess<object, object> set;
        private Operation<object, object> get;

        protected override bool SetContentsInternal(object target, object value)
        {
            if(set != null)
                return set(target, value);

            return false;
        }

        protected override object GetContentsInternal(object target)
        {
            if(get != null)
                return get(target);

            return null;
        }

        protected override string GetVariableNameInternal()
        {
            return name;
        }

        public Variable_Operation(Type d, Type v, string n, TryProcess<object, object> s, Operation<object, object> g) : base(d, v)
        {
            name = n;

            set = s;
            get = g;
        }
    }

    public class Variable_Operation<DECLARING_TYPE, VARIABLE_TYPE> : Variable_Operation
    {
        public Variable_Operation(string n, TryProcess<DECLARING_TYPE, VARIABLE_TYPE> s, Operation<VARIABLE_TYPE, DECLARING_TYPE> g)
            : base(typeof(DECLARING_TYPE), typeof(VARIABLE_TYPE), n,
                s.IfNotNull(p => (TryProcess<object, object>)delegate(object target, object value) {
                    DECLARING_TYPE target_cast;
                    VARIABLE_TYPE value_cast;

                    if (target.Convert<DECLARING_TYPE>(out target_cast))
                    {
                        if (value.Convert<VARIABLE_TYPE>(out value_cast, true))
                            return p(target_cast, value_cast);
                    }

                    return false;
                }),
                g.IfNotNull(o => (Operation<object, object>)delegate(object target) {
                    DECLARING_TYPE target_cast;

                    if (target.Convert<DECLARING_TYPE>(out target_cast))
                        return o(target_cast);

                    return default(VARIABLE_TYPE);
                })
            ) { }

        public Variable_Operation(string n, Process<DECLARING_TYPE, VARIABLE_TYPE> s, Operation<VARIABLE_TYPE, DECLARING_TYPE> g)
            : this(n,
                delegate(DECLARING_TYPE target, VARIABLE_TYPE value) {
                    s(target, value);

                    return true;
                },
                g
            ) { }
    }
}