using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public abstract class EphemeralDefinition
    {
        protected abstract int GetHashCodeInternal();
        protected abstract bool EqualsInternal(object obj);

        public abstract GameObject SpawnInstance();

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;

                hash = hash * 23 + GetType().GetHashCodeEX();
                hash = hash * 23 + GetHashCodeInternal();
                return hash;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj.GetTypeEX() == GetType())
                return EqualsInternal(obj);

            return false;
        }
    }
}