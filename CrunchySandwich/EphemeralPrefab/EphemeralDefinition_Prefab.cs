using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    public abstract class EphemeralDefinition_Prefab : EphemeralDefinition
    {
        [SerializeFieldEX]private GameObject prefab;

        protected override int GetHashCodeInternal()
        {
            return prefab.GetHashCodeEX();
        }

        protected override bool EqualsInternal(object obj)
        {
            EphemeralDefinition_Prefab cast;

            if (obj.Convert<EphemeralDefinition_Prefab>(out cast))
            {
                if (cast.prefab.EqualsEX(prefab))
                    return true;
            }

            return false;
        }

        public override GameObject SpawnInstance()
        {
            return prefab.SpawnInstance();
        }
    }
}