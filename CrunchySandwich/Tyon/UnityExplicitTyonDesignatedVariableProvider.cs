using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Salt;
    using Noodle;
    using Recipe;
    
    [UnityTyonSettingComponent]
    public class UnityExplicitTyonDesignatedVariableProvider : TyonDesignatedVariableProvider_Manual
    {
        private UnityExplicitTyonDesignatedVariableProvider() : base(
            new Variable_Operation<Timer, float>("duration", (t, v) => t.SetDurationInSeconds(v), t => t.GetDurationInSeconds())
        ) { }
    }
}