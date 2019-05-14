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
    static public class EditorGUIElementExtensions_Convenience
    {
        static public void LayoutDrawAndUnwind(this EditorGUIElement item, Rect rect, float label_width)
        {
            item.Layout(rect, label_width);
            item.Draw();
            item.Unwind();
        }

        static public EditorGUIElement InitilizeAndGet(this EditorGUIElement item)
        {
            item.Initilize();

            return item;
        }
    }
}