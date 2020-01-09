using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    [ExecuteInEditMode]
    [AddComponentMenu("Utility/MaintainScale")]
    public class MaintainScale : MonoBehaviour
    {
        [SerializeField]private Vector3 scale;

        private void Update()
        {
            this.SetSpacarScale(scale);
        }
    }
}