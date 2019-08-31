﻿using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
    public class TyonTypeHandler_Enum : TyonTypeHandler
    {
        static public readonly TyonTypeHandler_Enum INSTANCE = new TyonTypeHandler_Enum();

        private TyonTypeHandler_Enum() { }

        public override TyonValue Dehydrate(Type field_type, object value, TyonDehydrater dehydrater)
        {
            return new TyonValue_String(value, dehydrater);
        }

        public override bool IsCompatible(Type type)
        {
            if (type.IsEnumType())
                return true;

            return false;
        }
    }
}
