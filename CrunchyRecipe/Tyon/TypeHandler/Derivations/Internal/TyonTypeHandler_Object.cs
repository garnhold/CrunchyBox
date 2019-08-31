using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
    public class TyonTypeHandler_Object : TyonTypeHandler
    {
        static public readonly TyonTypeHandler_Object INSTANCE = new TyonTypeHandler_Object();

        private TyonTypeHandler_Object() { }

        public override TyonValue Dehydrate(Type field_type, object value, TyonDehydrater dehydrater)
        {
            return new TyonValue_Object(value, dehydrater);
        }

        public override bool IsCompatible(Type type)
        {
            if (GetSettings().GetDesignatedVariables(type).IsNotEmpty())
                return true;

            return false;
        }
    }
}
