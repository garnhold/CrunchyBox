using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public abstract class TyonTypeHandler_ExplicitType<T> : TyonTypeHandler
    {
        public override bool IsCompatible(Type type)
        {
            if (type == typeof(T))
                return true;

            return false;
        }
    }
}
