using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    [ExecuteInEditMode]
    [AddComponentMenu("Utility/MaintainScaleAspect")]
    public class MaintainScaleAspect : MonoBehaviour
    {
        [SerializeField]private Axis driving_axis = Axis.X;

        [SerializeField]private float axis1_aspect = 1.0f;
        [SerializeField]private float axis2_aspect = 1.0f;

        private void Update()
        {
            float driving_scale = this.GetSpacarScale().GetComponent(driving_axis);
            Vector3 unit_scale = driving_axis.GetVector3(1.0f, axis1_aspect, axis2_aspect);

            this.SetSpacarScale(driving_scale * unit_scale);
        }
    }
}