using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    [ExecuteInEditMode]
    [AddComponentMenu("Rendering/Parallax")]
    public class Parallax : MonoBehaviour
    {
        [SerializeField]private Vector3 origin;
        [SerializeField]private Vector3 multiplier;
        [SerializeField]private bool use_main_camera;

        private void Touch(Camera camera)
        {
            Vector3 difference = camera.GetSpacarPosition() - origin;

            this.SetPlanarPosition(origin + difference.GetComponentMultiply(multiplier));
        }

        private void Update()
        {
            if (use_main_camera == true)
                Touch(Camera.main);
        }
        private void OnWillRenderObject()
        {
            if (use_main_camera == false)
                Touch(Camera.current);
        }
    }
}