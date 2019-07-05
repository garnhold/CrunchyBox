using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class Motion_PeriodicFunction : Motion
    {
        [SerializeField]private PeriodicFunction function;

        public override float Execute(float input)
        {
            return function.Execute(input);
        }
    }
}