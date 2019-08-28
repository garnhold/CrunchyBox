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
    public class Methtoid
    {
        [SerializeFieldEX]private GameObject target;
        [SerializeFieldEX]private Invoketoid invoketoid;

        public Methtoid()
        {
            invoketoid = new Invoketoid();
        }

        public object Invoke()
        {
            return invoketoid.Invoke(target);
        }

        public Type GetTargetType()
        {
            return invoketoid.GetTargetType();
        }

        public Type GetReturnType()
        {
            return invoketoid.GetReturnType();
        }
    }
}