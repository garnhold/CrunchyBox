using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    public class FunctionInstance : MemberInstance
    {
        private Function function;

        public FunctionInstance(TargetInstance t, Function f) : base(t)
        {
            function = f;
        }

        public object Execute(bool convert, object[] arguments)
        {
            return function.Execute(GetTarget(), arguments);
        }

        public Function GetFunction()
        {
            return function;
        }

        public Type GetReturnType()
        {
            return function.GetReturnType();
        }

        public IEnumerable<Type> GetParameterTypes()
        {
            return function.GetParameterTypes();
        }

        public override string ToString()
        {
            return GetTargetInstance() + " -> " + function;
        }
    }

}