using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Salt;
    using Noodle;
    using Recipe;
    
    public abstract class Positioner : MonoBehaviourEX
    {
        [SerializeField] private GameObject target;

        protected abstract Vector3 CalculatePosition(GameObject target);

        private void Update()
        {
            this.SetSpacarPosition(CalculatePosition(GetTarget()));
        }

        public GameObject GetTarget()
        {
            return target.Coalesce(this.GetParent());
        }
    }
}