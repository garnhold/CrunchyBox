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
    public abstract class EditorGUIFragment
    {
        private Rect element_rect;

        public abstract void Draw();

        public void Layout(Rect rect)
        {
            element_rect = rect;
        }

        public Rect GetElementRect()
        {
            return element_rect;
        }
    }
}