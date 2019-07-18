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
    [Serializable]
    public class TargetMethod
    {
        [SerializeField]private TargetComponent target_component;

        private MethodInfo method;
        [SerializeField]private string method_name;

        public TargetMethod(TargetComponent c, MethodInfo m)
        {
            target_component = c;

            method = m;
            method_name = method.IfNotNull(z => z.Name);
        }

        public TargetMethod() : this(null, null) { }

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
            if (method == null || method.Name != method_name)
            {
                method = GetComponentType().IfNotNull(c => c.GetFilteredInstanceMethods(
                    Filterer_MethodInfo.IsNamed(method_name)
                )).GetFirst();
            }

            return method;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;

                hash = hash * 23 + target_component.GetHashCodeEX();
                hash = hash * 23 + method_name.GetHashCodeEX();
                return hash;
            }
        }

        public override bool Equals(object obj)
        {
            TargetMethod cast;

            if (obj.Convert<TargetMethod>(out cast))
            {
                if (cast.target_component.EqualsEX(target_component))
                {
                    if (cast.method_name == method_name)
                        return true;
                }
            }

            return false;
        }
    }
}