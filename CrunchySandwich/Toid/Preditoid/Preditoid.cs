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
    public class Preditoid
    {
        [SerializeFieldEX]private Invoketoid invoketoid;
        [SerializeFieldEX][PolymorphicField]private PreditoidComparer comparer;

        public Preditoid()
        {
            invoketoid = new Invoketoid();
        }

        public bool Check(GameObject target)
        {
            return comparer.Compare(invoketoid, target);
        }
    }
}