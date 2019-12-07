using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Noodle;
    using Bun;
    using Sandwich;

    public class ReflectedFunction : IDynamicCustomAttributeProvider
    {
        private ReflectedObject reflected_object;
        private Function function;

        private Variable_Static arguments;

        static public readonly ReflectedObject STATIC_TARGET = new ReflectedObject(new object());

        static public ReflectedFunction New(ReflectedObject reflected_object, Function function)
        {
            return new ReflectedFunction(reflected_object, function);
        }

        protected void Touch(string label, Process process)
        {
            reflected_object.Touch(label, process);
        }

        public ReflectedFunction(ReflectedObject o, Function f)
        {
            reflected_object = o;
            function = f;

            arguments = Variable_Static_Readonly_Value.New(new object[function.GetNumberParameters()]);
        }

        public void Execute()
        {
            Touch(GetFunctionName(), delegate() {
                reflected_object.GetObjects().Process(o => function.Execute(o, arguments.GetContents<object[]>()));
            });
        }

        public IEnumerable<ReflectedProperty> GetParameters()
        {
            return function.GetParameters().ConvertWithIndex(
                (i, p) => ReflectedProperty.New(
                    STATIC_TARGET, 
                    new Variable_Element(arguments, i).GetOverridenTypeAndNameVariable(p.Value, p.Key)
                )
            );
        }

        public ReflectedObject GetReflectedObject()
        {
            return reflected_object;
        }

        public Function GetFunction()
        {
            return function;
        }

        public string GetFunctionName()
        {
            return function.GetFunctionName();
        }

        public IEnumerable<Attribute> GetAllCustomAttributes(bool inherit)
        {
            return function.GetAllCustomAttributes(inherit);
        }
    }
}