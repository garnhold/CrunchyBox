using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchyNoodle;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    [SceneEXOnValidateEditDistinction]
    static public class SceneEXExtensions_OnValidate
    {
        [SceneEXOnValidateEditDistinction]
        static public void OnValidate(SceneEX item)
        {
            item.SetVariableValueByPath(
                "path",
                item.GetVariableValueByPath<SceneAsset>("scene_asset").IfNotNull(a => a.GetAssetPath())
            );
        }
    }
}