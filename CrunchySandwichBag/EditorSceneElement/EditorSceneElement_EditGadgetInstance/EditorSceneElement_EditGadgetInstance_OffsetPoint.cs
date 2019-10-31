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
    public class EditorSceneElement_EditGadgetInstance_OffsetPoint : EditorSceneElement_EditGadgetInstance
    {
        protected override void DrawInternal()
        {
            Vector3 local_point = this.GetContents<Vector3>();
            Vector3 parent_point = this.GetAuxContents<Vector3>("parent_point");

            Vector3 world_point = Handles.DoPositionHandle(local_point + parent_point, Quaternion.identity);

            this.SetContents(world_point - parent_point);
        }

        public EditorSceneElement_EditGadgetInstance_OffsetPoint(EditGadgetInstance g) : base(g)
        {
        }
    }
}