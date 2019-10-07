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
    [UnityTyonSettingComponent]
    public class UnityExplicitTyonDesignatedVariableProvider : TyonDesignatedVariableProvider_Manual
    {
        private UnityExplicitTyonDesignatedVariableProvider() : base(
            new Variable_Operation<Timer, float>("duration", (t, v) => t.SetDurationInSeconds(v), t => t.GetDurationInSeconds())
        ) { }
    }
}