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

        private void OnWillRenderObject()
        {
            Vector3 difference = Camera.current.GetSpacarPosition() - origin;

            this.SetPlanarPosition(origin + difference.GetComponentMultiply(multiplier));
        }
    }
}