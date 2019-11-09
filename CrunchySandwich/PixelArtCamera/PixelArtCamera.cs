using System;

using UnityEngine;

namespace CrunchySandwich
{
    [ExecuteAlways]
    [RequireComponent(typeof(Camera))]
    public class PixelArtCamera : MonoBehaviour
    {
        [SerializeField]private float pixels_per_unit;
        [SerializeField]private Vector2 resolution;

        private void Update()
        {
            Camera camera = this.GetComponent<Camera>();

            camera.SetPixelSizeCentered(resolution.GetFillByMultiplier(ScreenExtensions.GetSize(), 2.0f));
            camera.SetOrthographicSize(resolution / pixels_per_unit);
        }
    }
}