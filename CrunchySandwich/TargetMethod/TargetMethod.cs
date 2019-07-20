using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyBun;

namespace CrunchySandwich
{
    public class TargetMethod
    {
        [SerializeFieldEX]private TargetComponent target_component;
        [SerializeFieldEX]private MethodInfo method;

        public object Invoke(object[] arguments)
        {
            return GetMethod().Invoke(GetComponent(), arguments);
        }

        public GameObject GetGameObject()
        {
            return target_component.IfNotNull(c => c.GetGameObject());
        }

        public Component GetComponent()
        {
            return target_component.IfNotNull(c => c.GetComponent());
        }

        public Type GetComponentType()
        {
            return target_component.IfNotNull(c => c.GetComponentType());
        }

        public MethodInfo GetMethod()
        {
            return method;
        }
    }
}