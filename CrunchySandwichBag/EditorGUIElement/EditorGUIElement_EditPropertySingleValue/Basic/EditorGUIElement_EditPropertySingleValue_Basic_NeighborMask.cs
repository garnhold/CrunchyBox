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
    [EditorGUIElementForType(typeof(NeighborMask), true)]
    public class EditorGUIElement_EditPropertySingleValue_Basic_NeighborMask : EditorGUIElement_EditPropertySingleValue_Basic<NeighborMask>
    {
        protected override float DoPlanInternal()
        {
            return LINE_HEIGHT * 3.0f;
        }

        protected override NeighborMask DrawValueInternal(Rect rect, NeighborMask value)
        {
            new Rect(rect.position, Vector2.one.GetFilledDimension(rect.GetSize()))
                .ProcessGrid(3, 3, delegate(int x, int y, Rect sub_rect) {
                    if(x == 1 && y == 1)
                    {
                        GUIExtensions.DrawRect(sub_rect, Color.black);
                    }
                    else
                    {
                        int dx = x - 1;
                        int dy = y - 1;

                        bool has = value.HasBitAt(dx, dy);

                        if (GUIExtensions.ColorButton(sub_rect, has.ConvertBool(Color.black, Color.clear)))
                        {
                            if (has)
                                value = value.GetWithoutBitAt(dx, dy);
                            else
                                value = value.GetWithBitAt(dx, dy);
                        }
                    }
                });

            return value;
        }

        public EditorGUIElement_EditPropertySingleValue_Basic_NeighborMask(EditProperty_Single_Value p) : base(p) { }
    }
}