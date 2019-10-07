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
    public class StateSystemTyonSettings : TyonSettings_Distributed<UnityTyonSettingComponentAttribute>
    {
        static public readonly StateSystemTyonSettings INSTANCE = new StateSystemTyonSettings();

        private StateSystemTyonSettings() : base(
            StateSystemTyonDesignatedVariableProvider.INSTANCE,

            TyonTypeHandler_Substitute_ExplicitType<UnityEngine.Object, StateSystemPrefabReference>.INSTANCE
        )
        {
        }
    }
}