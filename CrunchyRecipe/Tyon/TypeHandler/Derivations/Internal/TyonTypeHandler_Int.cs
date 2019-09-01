using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
    public class TyonTypeHandler_Int : TyonTypeHandler
    {
        static public readonly TyonTypeHandler_Int INSTANCE = new TyonTypeHandler_Int();

        private TyonTypeHandler_Int() { }

        public override TyonValue Dehydrate(Type field_type, object value, TyonDehydrater dehydrater)
        {
            return new TyonValue_Int(value, dehydrater);
        }

        public override bool IsCompatible(Type type)
        {
            if (type.IsInteger())
                return true;

            return false;
        }
    }
}
