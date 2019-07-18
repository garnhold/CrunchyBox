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
    public class Functoid
    {
        [SerializeField]private TargetMethod target_method;
        [SerializeFieldEX]private object[] arguments;

        public Functoid(TargetMethod m, IEnumerable<object> a)
        {
            target_method = m;
            arguments = a.ToArray();
        }

        public Functoid() : this(null, null) { }

        public object Invoke()
        {
            return target_method.Invoke(arguments);
        }

        public MethodInfo GetMethod()
        {
            return target_method.IfNotNull(m => m.GetMethod());
        }

        public IEnumerable<object> GetArguments()
        {
            return arguments;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;

                hash = hash * 23 + target_method.GetHashCodeEX();
                hash = hash * 23 + arguments.GetElementsHashCode();
                return hash;
            }
        }

        public override bool Equals(object obj)
        {
            Functoid cast;

            if (obj.Convert<Functoid>(out cast))
            {
                if (cast.target_method.EqualsEX(target_method))
                {
                    if(cast.arguments.AreElementsEqual(arguments))
                        return true;
                }
            }

            return false;
        }
    }
}