using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
    public class TyonTypeHandler_Number : TyonTypeHandler
    {
        static public readonly TyonTypeHandler_Number INSTANCE = new TyonTypeHandler_Number();

        private TyonTypeHandler_Number() { }

        public override TyonValue Dehydrate(Type field_type, object value, TyonDehydrater dehydrater)
        {
            return new TyonValue_Number(value, dehydrater);
        }

        public override bool IsCompatible(Type type)
        {
            if (type.IsNumeric())
                return true;

            return false;
        }
    }
}
