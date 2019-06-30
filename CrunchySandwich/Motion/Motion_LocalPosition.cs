using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    [AddComponentMenu("Motion/Motion_LocalPosition")]
    public class Motion_LocalPosition : Motion
    {
        [SerializeField]
        [AttachEditGadget(
            "LocalPoint",
            new string[] { },
            new string[] {
                "local_to_world_matrix", "GetParentMatrix()" 
            }
        )]
        private Vector3 position1;

        [SerializeField]
        [AttachEditGadget(
            "LocalPoint",
            new string[] { },
            new string[] {
                "local_to_world_matrix", "GetParentMatrix()" 
            }
        )]
        private Vector3 position2;

        private void OnDrawGizmos()
        {
            Gizmos.matrix = GetParentMatrix();
            Gizmos.DrawLine(position1, position2);
        }

        private Matrix4x4 GetParentMatrix()
        {
            return this.GetParent().transform.localToWorldMatrix;
        }

        protected override void UpdateInternal(float value)
        {
            this.SetLocalSpacarPosition(position1.GetInterpolate(position2, value.ConvertFromOffsetToPercent()));
        }
    }
}