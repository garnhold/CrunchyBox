using System;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    
    static public partial class Project
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

        static public string GetGeneratedLeafDirectory()
        {
            return "Assets/Generated/Leaf/";
        }

        static public string GetEditorDirectory()
        {
            return "Assets/Editor/";
        }

        static public string GetEditorGeneratedDirectory()
        {
            return "Assets/Editor/Generated/";
        }

        static public string GetEditorGeneratedLeafDirectory()
        {
            return "Assets/Editor/Generated/Leaf/";
        }

        static public string GetInternalAssetDirectory()
        {
            return "Assets/InternalAssets/";
        }

        static public string GetAssetExtensionDirectory()
        {
            return "Assets/AssetExtensions/";
        }

        static public string GetResourcesDirectory()
        {
            return "Assets/Resources/";
        }

        static public string MakeUnusedCurrentDirectoryFilename(string base_name, string extension)
        {
            return Filename.MakeUnusedFilename(GetCurrentDirectory(), base_name, extension);
        }
    }
}