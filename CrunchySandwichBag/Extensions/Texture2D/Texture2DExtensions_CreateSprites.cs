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
    
    static public class Texture2DExtensions_CreateSprites
    {
        static public void CreateSprites(this Texture2D item, IEnumerable<Rect> rects)
        {
            item.ModifyAssetImporter(delegate (SerializedObject obj) {
                obj.SetChildValue("m_SpriteMode", (int)SpriteImportMode.Multiple);

                int index = 0;
                SerializedProperty sprites = obj.ForceProperty("m_SpriteSheet.m_Sprites");

                sprites.ClearArray();
                foreach (Rect rect in rects)
                {
                    SerializedProperty sprite = sprites.PushArrayElement();

                    sprite.SetChildValue("m_Name", item.name + "_" + index++);
                    sprite.SetChildValue("m_Rect", rect);
                }
            });
        }
    }
}