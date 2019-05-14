﻿using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
    public class TyonDesignatedVariableProvider_Fields_Public : TyonDesignatedVariableProvider_Fields
    {
        static public readonly TyonDesignatedVariableProvider_Fields_Public INSTANCE = new TyonDesignatedVariableProvider_Fields_Public();

        private TyonDesignatedVariableProvider_Fields_Public() { }

        protected override Filterer<FieldInfo> GetFieldInfoFilterer(Type type)
        {
            return Filterer_FieldInfo.IsPublicField();
        }
    }
}
