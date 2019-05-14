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
    public class EditorSceneElement_EditGadgetInstance_LocalPoint : EditorSceneElement_EditGadgetInstance
    {
        protected override void DrawInternal()
        {
            Vector3 local_point = this.GetContents<Vector3>();
            Matrix4x4 local_to_world_matrix = this.GetAuxContents<Matrix4x4>("local_to_world_matrix");

            Vector3 world_point = Handles.DoPositionHandle(local_to_world_matrix.MultiplyPoint(local_point), Quaternion.identity);
            Matrix4x4 world_to_local_matrix = local_to_world_matrix.inverse;

            this.SetContents(
                world_to_local_matrix.MultiplyPoint(world_point)
            );
        }

        public EditorSceneElement_EditGadgetInstance_LocalPoint(EditGadgetInstance g) : base(g)
        {
        }
    }
}