﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    [EditorGUIElementForType(typeof(TerrainSubTile), true)]
    public class EditorGUIElement_EditPropertySingleValue_Basic_TerrainSubTile : EditorGUIElement_EditPropertySingleValue_Basic<TerrainSubTile>
    {
        protected override float DoPlanInternal()
        {
            return LINE_HEIGHT * 8.0f;
        }

        protected override TerrainSubTile DrawValueInternal(Rect rect, TerrainSubTile value)
        {
            Sprite sprite = value.GetSprite();
            NeighborMask mask = value.GetMask();
            float weight = value.GetWeight();

            Rect left_rect;
            Rect right_rect;

            Rect weight_rect;

            Vector2 filled_dimension = Vector2.one.GetFilledDimension(rect.GetSize());

            rect.SplitByXLeftOffset(filled_dimension.x, out left_rect, out right_rect);
            right_rect.SplitByYBottomOffset(LINE_HEIGHT, out weight_rect, out right_rect);

            weight = EditorGUI.FloatField(weight_rect, "Weight", weight);

            left_rect
                .ProcessGrid(3, 3, delegate(int x, int y, Rect sub_rect) {
                    if(x == 1 && y == 1)
                    {
                        sprite = EditorGUIExtensions.SpriteDropZone(sub_rect, sprite);
                    }
                    else
                    {
                        int dx = x - 1;
                        int dy = y - 1;

                        bool has = mask.HasBitAt(dx, dy);

                        if (GUIExtensions.ColorButton(sub_rect, has.ConvertBool(Color.black, Color.gray)))
                        {
                            if (has)
                                mask = mask.GetWithoutBitAt(dx, dy);
                            else
                                mask = mask.GetWithBitAt(dx, dy);
                        }
                    }
                });

            return new TerrainSubTile(mask, sprite, weight);
        }

        public EditorGUIElement_EditPropertySingleValue_Basic_TerrainSubTile(EditProperty_Single_Value p) : base(p) { }
    }
}