using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public class ReflectedFunction : IDynamicCustomAttributeProvider
    {
        private ReflectedObject reflected_object;
        private CrunchyNoodle.Function function;

        private Variable_Static arguments;

        static public readonly ReflectedObject STATIC_TARGET = new ReflectedObject(new object());

        static public ReflectedFunction New(ReflectedObject reflected_object, CrunchyNoodle.Function function)
        {
            return new ReflectedFunction(reflected_object, function);
        }

        protected void Touch(string label, Process process)
        {
            reflected_object.Touch(label, process);
        }

        public ReflectedFunction(ReflectedObject o, CrunchyNoodle.Function f)
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

        public CrunchyNoodle.Function GetFunction()
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