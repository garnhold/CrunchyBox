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
    public class StateSystemTyonSettings : TyonSettings
    {
        static public readonly StateSystemTyonSettings INSTANCE = new StateSystemTyonSettings();

        private StateSystemTyonSettings() : base(
            StateSystemTyonDesignatedVariableProvider.INSTANCE,
            GeneralUnityTyonDesignatedVariableProvider.INSTANCE
        )
        {
        }
    }
}