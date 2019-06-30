using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public abstract class PeriodicFunction_Multiple : PeriodicFunction
    {
        [SerializeField]private List<PeriodicFunction> functions;

        public IEnumerable<PeriodicFunction> GetFunctions()
        {
            return functions;
        }
    }
}