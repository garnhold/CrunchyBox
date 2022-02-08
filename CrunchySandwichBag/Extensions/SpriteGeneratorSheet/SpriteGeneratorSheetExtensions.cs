using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Sandwich;
    
    static public class SpriteGeneratorSheetExtensions
    {
        static public Texture2D SaveAsAsset(this SpriteGeneratorSheet item, string name)
        {
            string filename = Project.MakeUnusedCurrentDirectoryFilename(name, "png");

            item.GenerateTexture().SaveAsPNG(filename);

            AssetDatabase.ImportAsset(filename);
            return AssetDatabase.LoadAssetAtPath<Texture2D>(filename);
        }
    }
}