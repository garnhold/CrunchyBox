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
    public class SaveStateTyonSettings : TyonSettings_Distributed<UnityTyonSettingComponentAttribute>
    {
        static public readonly SaveStateTyonSettings INSTANCE = new SaveStateTyonSettings();

        private SaveStateTyonSettings() : base(
            SaveStateTyonDesignatedVariableProvider.INSTANCE,

            TyonTypeHandler_Substitute_ExplicitType<MonoBehaviourEX, SaveStateMonoBehaviourEXPrefabReference>.INSTANCE,
            TyonTypeHandler_Substitute_ExplicitType<ScriptableObjectEX, SaveStateScriptableObjectEXSofabReference>.INSTANCE
        )
        {
        }
    }
}