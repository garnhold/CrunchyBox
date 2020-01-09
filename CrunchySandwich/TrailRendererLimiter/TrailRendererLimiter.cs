using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    [AddComponentMenu("Rendering/TrailRendererLimiter")]
    [RequireComponent(typeof(TrailRenderer))]
    public class TrailRendererLimiter : MonoBehaviour
    {
        private void Start()
        {
            this.GetComponent<TrailRenderer>().Clear();
        }
    }
}