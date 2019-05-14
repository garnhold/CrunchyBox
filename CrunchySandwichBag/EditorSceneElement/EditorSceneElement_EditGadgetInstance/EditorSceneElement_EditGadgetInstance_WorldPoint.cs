using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchySauce;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public class EditorSceneElement_EditGadgetInstance_WorldPoint : EditorSceneElement_EditGadgetInstance
    {
        protected override void DrawInternal()
        {
            this.SetContents(
                Handles.DoPositionHandle(this.GetContents<Vector3>(), Quaternion.identity)
            );
        }

        public EditorSceneElement_EditGadgetInstance_WorldPoint(EditGadgetInstance g) : base(g)
        {
        }
    }
}