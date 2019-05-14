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
    public class UnityTyonSerializationSettings : TyonSerializationSettings
    {
        static public readonly UnityTyonSerializationSettings INSTANCE = new UnityTyonSerializationSettings();

        private UnityTyonSerializationSettings() : base(
            UnityTyonDesignatedVariableProvider.INSTANCE,
            GeneralUnityTyonDesignatedVariableProvider.INSTANCE,

            TyonBridge_RegisterExternal_Type<UnityEngine.Object>.INSTANCE
        )
        {
        }
    }
}