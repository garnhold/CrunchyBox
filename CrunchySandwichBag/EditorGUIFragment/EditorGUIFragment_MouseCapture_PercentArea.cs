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
    public class EditorGUIFragment_MouseCapture_PercentArea : EditorGUIFragment_MouseCapture
    {
        private Process<int, Vector2> process;

        public EditorGUIFragment_MouseCapture_PercentArea(Process<int, Vector2> p)
        {
            process = p;
        }

        public override void Draw()
        {
            GetControl().UpdatePercentPoint(GetElementRect(), process);
        }
    }
}