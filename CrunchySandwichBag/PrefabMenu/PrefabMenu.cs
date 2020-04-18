using System;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Salt;
    using Noodle;
    using Ginger;
    using Sandwich;
    
    static public class PrefabMenu
    {
        [MenuItem("Assets/Create Empty Prefab")]
        static private void CreateEmptyPrefab()
        {
            GameObject game_object = new GameObject();

            PrefabUtility.SaveAsPrefabAsset(
                game_object,
                Filename.MakeUnusedFilename(Project.GetCurrentDirectory(), "New Prefab", "prefab")
            );

            game_object.DestroyAdvisory();
        }
    }
}