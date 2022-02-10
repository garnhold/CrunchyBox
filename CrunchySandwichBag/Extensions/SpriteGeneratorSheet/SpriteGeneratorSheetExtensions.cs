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
        static public void SaveAsAsset(this SpriteGeneratorSheet item, string name)
        {
            string filename = Project.MakeUnusedCurrentDirectoryFilename(name, "png");

            Texture2D temp;
            List<SpriteGeneratorSheetFrame> frames = item.Generate(out temp, 1024)
                .ToList();

            temp.SaveAsPNG(filename);

            AssetDatabase.ImportAsset(filename);
            AssetDatabase.LoadAssetAtPath<Texture2D>(filename)
                .CreateSprites(
                    frames.Convert(f => Tuple.New(f.GetRect(), f.GetPivot()))
                );
        }
    }
}