using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyRecipe;

namespace CrunchySandwich
{
    public class UnityTyonSettings : TyonSettings
    {
        static public readonly UnityTyonSettings INSTANCE = new UnityTyonSettings();

        private UnityTyonSettings() : base(
            UnityTyonDesignatedVariableProvider.INSTANCE,
            GeneralUnityTyonDesignatedVariableProvider.INSTANCE,

            TyonTypeHandler_Externalize_ExplicitType<UnityEngine.Object>.INSTANCE,

            TyonTypeHandler_MethodInfo.INSTANCE,

            TyonDesignatedVariableProvider_Propertys_Public.INSTANCE
        )
        {
        }
    }
}