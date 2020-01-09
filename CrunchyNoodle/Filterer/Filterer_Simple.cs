using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
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