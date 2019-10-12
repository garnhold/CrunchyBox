using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    public class Function_Operation : Function
    {
        private string name;
        private Operation<object, object, object[]> operation;

        protected override object ExecuteInternal(object target, params object[] arguments)
        {
            if(operation != null)
                return operation(target, arguments);

            return null;
        }

        protected override string GetFunctionNameInternal()
        {
            return name;
        }

        public Function_Operation(Type t, Type r, string n, IEnumerable<Type> p, Operation<object, object, object[]> o) : base(t, r, p.Convert(z => KeyValuePair.New("parameter", z)))
        {
            name = n;

            operation = o;
        }
    }

    public class Function_Operation<TARGET_TYPE, RETURN_TYPE> : Function_Operation
    {
        public Function_Operation(string n, Operation<RETURN_TYPE, TARGET_TYPE> o)
            : base(typeof(TARGET_TYPE), typeof(RETURN_TYPE), n, null,
                delegate(object target, object[] arguments) {
                    TARGET_TYPE target_cast;

                    if (target.Convert<TARGET_TYPE>(out target_cast))
                        return o(target_cast);

                    return null;
                }
            ) { }
    }
}