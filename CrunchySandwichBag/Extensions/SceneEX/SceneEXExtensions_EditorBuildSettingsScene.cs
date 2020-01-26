using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;    using Sandwich;
    
    static public class SceneEXExtensions_EditorBuildSettingsScene
    {
        static public EditorBuildSettingsScene GetEditorBuildSettingsScene(this SceneEX item, bool enabled)
        {
            return new EditorBuildSettingsScene(item.GetSceneAsset().GetAssetPath(), enabled);
        }
    }
}