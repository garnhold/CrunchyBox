using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    [AddComponentMenu("Motion/MotionController_LocalPlanarZPosition")]
    public class MotionController_LocalPlanarZPosition : MotionController
    {
        [SerializeField]
        [AttachEditGadget(
            "LocalOffset",
            new string[] { },
            new string[] {
                "local_direction", "GetLocalDirection()",
                "local_to_world_matrix", "GetParentMatrix()" 
            }
        )]
        private float position1;

        [SerializeField]
        [AttachEditGadget(
            "LocalOffset",
            new string[] { },
            new string[] {
                "local_direction", "GetLocalDirection()",
                "local_to_world_matrix", "GetParentMatrix()" 
            }
        )]
        private float position2;

        private void OnDrawGizmos()
        {
            Gizmos.matrix = GetParentMatrix();
            Gizmos.DrawLine(GetLocalDirection() * position1, GetLocalDirection() * position2);
        }

        private Vector3 GetLocalDirection()
        {
            return Vector3.forward;
        }

        private Matrix4x4 GetParentMatrix()
        {
            return this.GetParent().transform.localToWorldMatrix;
        }

        protected override void UpdateInternal(float value)
        {
            this.SetLocalPlanarZPosition(
                position1.GetInterpolate(position2, value.ConvertFromOffsetToPercent())
            );
        }
    }
}