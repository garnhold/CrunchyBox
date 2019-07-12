using System;
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
    public class EditorGUIElement_EditPropertyValue_NeighborMask : EditorGUIElement_EditPropertyValue<NeighborMask>
    {
        protected override NeighborMask DrawValueInternal(Rect rect, NeighborMask value)
        {
            rect.ProcessGrid(3, 3, delegate(int x, int y, Rect sub_rect) {
                if(x == 1 && y == 1)
                {
                }
                else
                {
                    int dx = x - 1;
                    int dy = y - 1;

                    bool has = value.HasBitAt(dx, dy);

                    if (GUI.Button(sub_rect, has.ConvertBool("X", "_")))
                    {
                        if (has)
                            value = value.GetWithoutBitAt(dx, dy);
                        else
                            value = value.GetWithBitAt(dx, dy);

                        GUI.changed = true;
                    }
                }
            });

            return value;
        }

        protected override float CalculateElementHeightInternal()
        {
            return LINE_HEIGHT * 3.0f;
        }

        public EditorGUIElement_EditPropertyValue_NeighborMask(EditProperty_Value p) : base(p) { }
    }
}