using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Noodle;    using Sandwich;
    
    public class EditFunction : IDynamicCustomAttributeProvider
    {
        private EditTarget target;
        private Function function;

        private Variable_Static arguments;

        static public readonly EditTarget STATIC_TARGET = new EditTarget(new object());

        static public EditFunction New(EditTarget target, Function function)
        {
            return new EditFunction(target, function);
        }

        public EditFunction(EditTarget t, Function f)
        {
            target = t;
            function = f;

            arguments = Variable_Static_Readonly_Value.New(new object[function.GetNumberParameters()]);
        }

        public void Execute()
        {
            target.Touch(GetName(), delegate () {
                target.GetObjects().Process(o => function.Execute(o, arguments.GetContents<object[]>()));
            }, true);
        }

        public string GetName()
        {
            return function.GetFunctionName();
        }

        public IEnumerable<EditProperty> GetParameters()
        {
            return function.GetParameters().ConvertWithIndex(
                (i, p) => EditProperty.New(
                    STATIC_TARGET,
                    new Variable_Element(arguments, i).GetOverridenTypeAndNameVariable(p.Value, p.Key)
                )
            );
        }

        public EditTarget GetTarget()
        {
            return target;
        }

        public EditorGUIElement CreateEditorGUIElement()
        {
            return new EditorGUIElement_EditFunction_Button(this);
        }

        public IEnumerable<Attribute> GetAllCustomAttributes(bool inherit)
        {
            return function.GetAllCustomAttributes(inherit);
        }
    }
}