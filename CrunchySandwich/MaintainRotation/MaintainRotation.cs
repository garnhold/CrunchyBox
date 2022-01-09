using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    [ExecuteInEditMode]
    [AddComponentMenu("Utility/MaintainRotation")]
    public class MaintainRotation : MonoBehaviour
    {
        [SerializeField]private Vector3 rotation;

        private void Update()
        {
            this.SetSpacarRotation(rotation);
        }
    }
}