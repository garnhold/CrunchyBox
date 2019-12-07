using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class TyonTypeHandler_Externalize_ExplicitType<T> : TyonTypeHandler_Externalize_ExplicitType
    {
        static public readonly TyonTypeHandler_Externalize_ExplicitType<T> INSTANCE = new TyonTypeHandler_Externalize_ExplicitType<T>();

        private TyonTypeHandler_Externalize_ExplicitType() : base(typeof(T)) { }
    }

    public class TyonTypeHandler_Externalize_ExplicitType : TyonTypeHandler_Externalize
    {
        private Type target_type;

        public TyonTypeHandler_Externalize_ExplicitType(Type t)
        {
            target_type = t;
        }

        public override bool IsCompatible(Type type)
        {
            if (type.CanBeTreatedAs(target_type))
                return true;

            return false;
        }
    }
}
