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
    public class ReflectedProperty_Single_Object : ReflectedProperty_Single
    {
        public ReflectedProperty_Single_Object(ReflectedObject o, Variable v) : base(o, v)
        {
        }

        public override bool IsUnified()
        {
            return true;
        }
    }
}