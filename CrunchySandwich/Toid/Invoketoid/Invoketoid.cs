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
    public class Invoketoid
    {
        [SerializeFieldEX]private Type target_type;
        [SerializeFieldEX]private MethodInfo target_method;

        [SerializeFieldEX][PolymorphicField]private InvoketoidInvokerBase invoker;

        public object Invoke(GameObject target)
        {
            if (target_type != null && target_method != null)
                return invoker.Invoke(target.GetComponentUpward(target_type), target_method);

            return null;
        }
    }
}