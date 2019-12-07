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
    
    public class EditFunction_Reflected : EditFunction
    {
        private ReflectedFunction function;

        public EditFunction_Reflected(EditTarget t, ReflectedFunction f) : base(t)
        {
            function = f;
        }

        public override void Execute()
        {
            function.Execute();
        }

        public override IEnumerable<EditProperty> GetParameters()
        {
            return function.GetParameters().Convert(p => EditTarget_Reflected.CreateProperty(GetTarget(), p));
        }

        public override string GetName()
        {
            return function.GetFunctionName();
        }

        public override IEnumerable<Attribute> GetAllCustomAttributes(bool inherit)
        {
            return function.GetAllCustomAttributes(inherit);
        }
    }
}