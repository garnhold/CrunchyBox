using System;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyNoodle;
using CrunchySalt;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    static public class SceneAssetExtensions_SceneEX
    {
        static public SceneEX CreateSceneEX(this SceneAsset item)
        {
            return CustomAssets.CreateExternalCustomAsset<SceneEX>(
                Filename.SetExtension(item.GetAssetPath(), "asset"),
                s => s.Initialize(item)
            );
        }

        [MenuItem("Assets/SceneEX")]
        static private void CreateSceneEX()
        {
            ((SceneAsset)Selection.activeObject).CreateSceneEX();
        }

        [MenuItem("Assets/SceneEX", true)]
        static private bool CreateSceneEXValidate()
        {
            if (Selection.activeObject is SceneAsset)
                return true;

            return false;
        }
    }
}