using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class Action_Function : Action
    {
        private Function function;
        private object[] arguments;

        static public Action_Function New(Function function, IEnumerable<object> arguments)
        {
            return new Action_Function(function, arguments);
        }
        static public Action_Function New(Function function, params object[] arguments)
        {
            return New(function, (IEnumerable<object>)arguments);
        }

        protected override void ExecuteInternal(object target)
        {
            function.Execute(target, arguments);
        }

        protected override string GetActionNameInternal()
        {
            return function.GetFunctionName();
        }

        protected override IEnumerable<Attribute> GetAllCustomAttributesInternal(bool inherit)
        {
            return function.GetAllCustomAttributes(inherit);
        }

        public Action_Function(Function f, IEnumerable<object> a) : base(f.GetDeclaringType())
        {
            function = f;

            arguments = a.ToArray();
        }
    }
}