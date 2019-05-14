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
    public class ReflectedAction : IDynamicCustomAttributeProvider
    {
        private ReflectedObject reflected_object;
        private CrunchyNoodle.Action action;

        static public ReflectedAction New(ReflectedObject reflected_object, CrunchyNoodle.Action action)
        {
            return new ReflectedAction(reflected_object, action);
        }

        protected void Touch(string label, Process process)
        {
            reflected_object.Touch(label, process);
        }

        public ReflectedAction(ReflectedObject o, CrunchyNoodle.Action a)
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

        public CrunchyNoodle.Action GetAction()
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