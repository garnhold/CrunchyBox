using System;

using UnityEngine;

namespace CrunchySandwich
{
    [ExecuteInEditMode]
    [AddComponentMenu("Utility/MaintainScaleAspect")]
    public class MaintainScaleAspect : MonoBehaviour
    {
        [SerializeField]private Axis driving_axis;

        [SerializeField]private float axis1_aspect;
        [SerializeField]private float axis2_aspect;

        private void Update()
        {
            float driving_scale = this.GetSpacarScale().GetComponent(driving_axis);
            Vector3 unit_scale = driving_axis.GetVector3(1.0f, axis1_aspect, axis2_aspect);

            this.SetSpacarScale(driving_scale * unit_scale);
        }
    }
}