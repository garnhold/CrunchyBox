using System;

using UnityEngine;
using UnityEditor;

using CrunchyDough;

namespace CrunchySandwichBag
{
    static public class Project
    {
        static public string GetCurrentDirectory()
        {
            return Selection.activeObject.GetAssetDirectory();
        }

        static public string GetAssetDirectory()
        {
            return "Assets/";
        }

        static public string GetGeneratedDirectory()
        {
            return "Assets/Generated/";
        }

        static public string GetEditorDirectory()
        {
            return "Assets/Editor/";
        }

        static public string GetEditorGeneratedDirectory()
        {
            return "Assets/Editor/Generated/";
        }

        static public string GetInternalAssetDirectory()
        {
            return "Assets/InternalAssets/";
        }

        static public string GetResourcesDirectory()
        {
            return "Assets/Resources/";
        }

        static public string MakeNewCurrentDirectoryFilename(string base_name, string extension)
        {
            return Filename.MakeNewFilename(GetCurrentDirectory(), base_name, extension);
        }
    }
}