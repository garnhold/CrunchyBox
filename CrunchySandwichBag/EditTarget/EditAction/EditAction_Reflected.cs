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
    
    public class EditAction_Reflected : EditAction
    {
        private ReflectedAction action;

        public EditAction_Reflected(EditTarget t, ReflectedAction a) : base(t)
        {
            action = a;
        }

        public override void Execute()
        {
            action.Execute();
        }

        public override string GetName()
        {
            return action.GetActionName();
        }

        public override IEnumerable<Attribute> GetAllCustomAttributes(bool inherit)
        {
            return action.GetAllCustomAttributes(inherit);
        }
    }
}