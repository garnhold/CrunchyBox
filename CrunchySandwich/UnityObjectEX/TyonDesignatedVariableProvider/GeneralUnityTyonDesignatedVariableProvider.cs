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
    public class GeneralUnityTyonDesignatedVariableProvider : TyonDesignatedVariableProvider_Manual
    {
        static public readonly GeneralUnityTyonDesignatedVariableProvider INSTANCE = new GeneralUnityTyonDesignatedVariableProvider();

        private GeneralUnityTyonDesignatedVariableProvider() : base(
            new Variable_Operation<Timer_Duration, float>("duration", (t, v) => t.SetDurationInSeconds(v), t => t.GetDurationInSeconds()),
            new Variable_Operation<RateLimiter, float>("rate", (t, v) => t.SetRate(v), t => t.GetRate())
        ) { }
    }
}