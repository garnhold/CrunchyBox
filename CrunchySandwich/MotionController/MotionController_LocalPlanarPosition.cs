using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    [AddComponentMenu("Motion/MotionController_LocalPlanarPosition")]
    public class MotionController_LocalPlanarPosition : MotionController
    {
        [SerializeField]
        [AttachEditGadget(
            "LocalPoint",
            new string[] { },
            new string[] {
                "local_to_world_matrix", "GetParentMatrix()" 
            }
        )]
        private Vector2 position1;

        [SerializeField]
        [AttachEditGadget(
            "LocalPoint",
            new string[] { },
            new string[] {
                "local_to_world_matrix", "GetParentMatrix()" 
            }
        )]
        private Vector2 position2;

        private void OnDrawGizmos()
        {
            Gizmos.matrix = GetParentMatrix();
            Gizmos.DrawLine(position1, position2);
        }

        private Matrix4x4 GetParentMatrix()
        {
            return GetTarget().GetParent().transform.localToWorldMatrix;
        }

        protected override void UpdateInternal(float value)
        {
            GetTarget().SetLocalPlanarPosition(position1.GetInterpolate(position2, value.ConvertFromOffsetToPercent()));
        }
    }
}