using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public class ScriptExecutionOrderAttribute : Attribute
    {
        private int order;

        public ScriptExecutionOrderAttribute(int o)
        {
            order = o;
        }

        public int GetOrder()
        {
            return order;
        }
    }
}