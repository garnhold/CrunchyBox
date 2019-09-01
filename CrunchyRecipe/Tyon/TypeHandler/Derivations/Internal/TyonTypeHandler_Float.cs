using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
    public class TyonTypeHandler_Float : TyonTypeHandler
    {
        static public readonly TyonTypeHandler_Float INSTANCE = new TyonTypeHandler_Float();

        private TyonTypeHandler_Float() { }

        public override TyonValue Dehydrate(Type field_type, object value, TyonDehydrater dehydrater)
        {
            return new TyonValue_Float(value, dehydrater);
        }

        public override bool IsCompatible(Type type)
        {
            if (type.IsReal())
                return true;

            return false;
        }
    }
}
