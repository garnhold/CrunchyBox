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
    public class Checktoid
    {
        [SerializeFieldEX]private GameObject target;
        [SerializeFieldEX]private Preditoid preditoid;

        public Checktoid()
        {
            preditoid = new Preditoid();
        }

        public bool Check()
        {
            return preditoid.Check(target);
        }
    }
}