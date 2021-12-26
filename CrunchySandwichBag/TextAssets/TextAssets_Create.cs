using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Noodle;
    using Sandwich;
    
    static public partial class TextAssets
    {
        static public TextAsset CreateTextAssetWithFilenameAndContents(string filename, string contents)
        {
            File.WriteAllText(filename, contents);

            AssetDatabase.ImportAsset(filename);
            AssetDatabase.SaveAssets();

            return AssetDatabase.LoadAssetAtPath<TextAsset>(filename);
        }

        static public TextAsset CreateTextAssetWithFilename(string filename)
        {
            return CreateTextAssetWithFilenameAndContents(filename, "");
        }

        static public TextAsset CreateTextAsset(string base_name, string extension)
        {
            return CreateTextAssetWithFilename(Project.MakeUnusedCurrentDirectoryFilename(base_name, extension));
        }
    }
}