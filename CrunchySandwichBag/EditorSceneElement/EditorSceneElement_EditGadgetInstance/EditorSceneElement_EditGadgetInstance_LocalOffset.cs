using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Sauce;
    using Sandwich;
    
    public class EditorSceneElement_EditGadgetInstance_LocalOffset : EditorSceneElement_EditGadgetInstance
    {
        protected override void DrawInternal()
        {
            float local_offset = this.GetContents<float>();
            Vector3 local_direction = this.GetAuxContents<Vector3>("local_direction");
            Matrix4x4 local_to_world_matrix = this.GetAuxContents<Matrix4x4>("local_to_world_matrix");

            Vector3 local_point = local_direction * local_offset;

            Vector3 world_point = Handles.DoPositionHandle(local_to_world_matrix.MultiplyPoint(local_point), Quaternion.identity);
            Matrix4x4 world_to_local_matrix = local_to_world_matrix.inverse;

            this.SetContents(
                world_to_local_matrix.MultiplyPoint(world_point).GetDot(local_direction)
            );
        }

        public EditorSceneElement_EditGadgetInstance_LocalOffset(EditGadgetInstance g) : base(g)
        {
        }
    }
}