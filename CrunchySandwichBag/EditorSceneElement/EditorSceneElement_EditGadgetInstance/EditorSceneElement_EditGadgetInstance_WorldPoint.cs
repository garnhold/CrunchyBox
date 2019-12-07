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