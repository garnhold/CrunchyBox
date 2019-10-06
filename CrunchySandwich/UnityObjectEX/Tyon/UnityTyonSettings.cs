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
            UnityExplicitTyonDesignatedVariableProvider.INSTANCE,

            TyonTypeHandler_Externalize_ExplicitType<UnityEngine.Object>.INSTANCE,
            TyonTypeHandler_MethodInfo.INSTANCE
        )
        {
        }
    }
}