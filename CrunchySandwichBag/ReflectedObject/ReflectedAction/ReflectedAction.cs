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

    public class ReflectedAction : IDynamicCustomAttributeProvider
    {
        private ReflectedObject reflected_object;
        private Action action;

        static public ReflectedAction New(ReflectedObject reflected_object, Action action)
        {
            return new ReflectedAction(reflected_object, action);
        }

        protected void Touch(string label, Process process)
        {
            reflected_object.Touch(label, process);
        }

        public ReflectedAction(ReflectedObject o, Action a)
        {
            reflected_object = o;
            action = a;
        }

        public void Execute()
        {
            Touch(GetActionName(), delegate() {
                reflected_object.GetObjects().Process(o => action.Execute(o));
            });
        }

        public ReflectedObject GetReflectedObject()
        {
            return reflected_object;
        }

        public Action GetAction()
        {
            return action;
        }

        public string GetActionName()
        {
            return action.GetActionName();
        }

        public IEnumerable<Attribute> GetAllCustomAttributes(bool inherit)
        {
            return action.GetAllCustomAttributes(inherit);
        }
    }
}