using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyNoodle
{
    public abstract class Filterer_Simple<T> : Filterer<T>
    {
        protected override bool EqualsInternal(object obj)
        {
            return true;
        }

        protected override int GetHashCodeInternal()
        {
            return 1;
        }

        protected override string GetIdentityInternal()
        {
            return "";
        }
    }
}