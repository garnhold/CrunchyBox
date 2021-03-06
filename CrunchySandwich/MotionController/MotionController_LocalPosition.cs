﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    [AddComponentMenu("Motion/MotionController_LocalPosition")]
    public class MotionController_LocalPosition : MotionController
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