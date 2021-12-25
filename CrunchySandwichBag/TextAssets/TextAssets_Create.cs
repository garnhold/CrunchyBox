using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Noodle;
    using Sandwich;
    
    static public partial class TextAssets
    {
        static public TextAsset CreateTextAssetWithFilenameAndContents(string filename, string contents)
        {
            TextAsset asset = new TextAsset(contents);

            asset.SaveNewAsset(filename);
            asset.FocusAsset();
            return asset;
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