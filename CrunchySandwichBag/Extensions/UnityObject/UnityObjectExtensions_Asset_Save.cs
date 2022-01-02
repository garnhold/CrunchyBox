using System;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Sandwich;
    
    static public class UnityObjectExtensions_Asset_Save
    {
        static public void SaveNewAsset(this UnityEngine.Object item, string filename)
        {
            if (Filename.HasExtension(filename) == false)
                filename = Filename.SetExtension(filename, "asset");

            AssetDatabase.CreateAsset(item, Files.GetUnusedFilename(filename));
            AssetDatabase.SaveAssets();
        }

        static public void SaveAsset(this UnityEngine.Object item)
        {
            EditorUtility.SetDirty(item);
            AssetDatabase.SaveAssets();
        }

        static public void FocusAsset(this UnityEngine.Object item)
        {
            EditorUtility.FocusProjectWindow();
            Selection.activeObject = item;
        }
    }
}