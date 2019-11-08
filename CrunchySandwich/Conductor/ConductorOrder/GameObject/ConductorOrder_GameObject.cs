using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public abstract class ConductorOrder_GameObject : ConductorOrder
    {
        private GameObject target;

        public ConductorOrder_GameObject(GameObject t)
        {
            target = t;
        }

        public GameObject GetTarget()
        {
            return target;
        }
    }
}