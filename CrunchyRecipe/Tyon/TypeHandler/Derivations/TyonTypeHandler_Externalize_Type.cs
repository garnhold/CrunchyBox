using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
    public class TyonTypeHandler_Externalize_Type<T> : TyonTypeHandler_Externalize_Type
    {
        static public readonly TyonTypeHandler_Externalize_Type<T> INSTANCE = new TyonTypeHandler_Externalize_Type<T>();

        private TyonTypeHandler_Externalize_Type() : base(typeof(T)) { }
    }

    public class TyonTypeHandler_Externalize_Type : TyonTypeHandler_Externalize
    {
        private Type target_type;

        public TyonTypeHandler_Externalize_Type(Type t)
        {
            target_type = t;
        }

        public override bool IsDehydrater(Type type)
        {
            if (type.CanBeTreatedAs(target_type))
                return true;

            return false;
        }
    }
}
