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

            TyonBridge_RegisterExternal_Type<UnityEngine.Object>.INSTANCE,

            TyonBridge_CalculateExternal_Type_Type.INSTANCE,
            TyonBridge_CalculateExternal_Type_MethodInfo.INSTANCE
        )
        {
        }
    }
}