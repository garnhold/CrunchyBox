using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public abstract class IdentifiableObject : Identifiable
    {
        protected abstract bool EqualsInternal(object obj);
        protected abstract int GetHashCodeInternal();
        protected abstract string GetIdentityInternal();

        public override bool Equals(object obj)
        {
            if (obj.IsObjectType(GetType()))
                return EqualsInternal(obj);

            return false;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;

                hash = hash * 23 + GetType().GetHashCode();
                hash = hash * 23 + GetHashCodeInternal();
                return hash;
            }
        }

        public string GetIdentity()
        {
            return GetType().Name + GetIdentityInternal();
        }
    }
}