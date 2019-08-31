using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
    public class TyonTypeHandler_String : TyonTypeHandler, TyonTypeDehydrater
    {
        static public readonly TyonTypeHandler_String INSTANCE = new TyonTypeHandler_String();

        private TyonTypeHandler_String() { }

        public TyonValue Dehydrate(Type field_type, object value, TyonDehydrater dehydrater)
        {
            return new TyonValue_String(value, dehydrater);
        }

        public bool IsDehydrater(Type type)
        {
            if (type.IsString())
                return true;

            return false;
        }
    }
}
