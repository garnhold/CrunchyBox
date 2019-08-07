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
    public class Functoid
    {
        [SerializeFieldEX]private TargetMethod target_method;
        [SerializeFieldEX][PolymorphicField]private FunctoidInvokerBase invoker;

        public Functoid()
        {
            target_method = new TargetMethod();
        }

        public object Invoke()
        {
            Component component = GetComponent();
            MethodInfo method = GetMethod();

            if (component != null && method != null)
                return invoker.Invoke(component, method);

            return null;
        }

        public Component GetComponent()
        {
            return target_method.IfNotNull(m => m.GetComponent());
        }

        public MethodInfo GetMethod()
        {
            return target_method.IfNotNull(m => m.GetMethod());
        }
    }
}