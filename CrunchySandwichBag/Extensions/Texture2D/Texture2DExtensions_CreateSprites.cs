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
        static public void CreateSprites(this Texture2D item, IEnumerable<Tuple<Rect, Vector2>> rect_and_pivots)
        {
            item.ModifyAssetImporter(delegate (SerializedObject obj) {
                obj.SetChildValue("m_SpriteMode", (int)SpriteImportMode.Multiple);

                int index = 0;
                SerializedProperty sprites = obj.ForceProperty("m_SpriteSheet.m_Sprites");

                sprites.ClearArray();
                foreach (Tuple<Rect, Vector2> rect_and_pivot in rect_and_pivots)
                {
                    SerializedProperty sprite = sprites.PushArrayElement();

                    sprite.SetChildValue("m_Name", item.name + "_" + index++);

                    sprite.ForceProperty("m_Rect").rectValue = rect_and_pivot.item1;
                    sprite.ForceProperty("m_Pivot").vector2Value = rect_and_pivot.item2;
                    sprite.ForceProperty("m_Alignment").intValue = (int)rect_and_pivot.item2.GetSpriteAlignment();
                }
            });
        }
    }
}