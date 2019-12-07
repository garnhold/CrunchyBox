using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Bun;
    using Sauce;
    using Sandwich;
    
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