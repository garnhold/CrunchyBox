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
    public class UnityTyonSerializer : TyonSerializer
    {
        static public readonly UnityTyonSerializer INSTANCE = new UnityTyonSerializer();

        private UnityTyonSerializer() : base(
            UnityTyonDesignatedVariableProvider.INSTANCE,
            GeneralUnityTyonDesignatedVariableProvider.INSTANCE,

            TyonBridge_RegisterExternal_Type<UnityEngine.Object>.INSTANCE
        )
        {
        }
    }
}