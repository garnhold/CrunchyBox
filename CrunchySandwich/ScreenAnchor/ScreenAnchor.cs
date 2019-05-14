using System;

using UnityEngine;

namespace CrunchySandwich
{
    [ExecuteInEditMode]
    public class ScreenAnchor : MonoBehaviour
    {
        [SerializeField]private Vector2 offset;
        [SerializeField]private float angle;

        [SerializeField]private Vector2 self_origin_offset_percent;
        [SerializeField]private Vector2 screen_origin_offset_percent;

        private void Update()
        {
            Camera camera = GetComponentInParent<Camera>() ?? Camera.main;

            if (camera != null)
            {
                Vector2 self_origin = self_origin_offset_percent.GetComponentMultiply(this.GetPlanarSize());
                Vector2 screen_origin = screen_origin_offset_percent.GetComponentMultiply(camera.GetOrthographicSize());

                this.SetPlanarPosition(
                    camera.transform.TransformPoint(screen_origin - self_origin + offset)
                );

                this.SetPlanarRotation(
                    camera.GetPlanarRotation() + angle
                );
            }
        }

        public void SetOffset(Vector2 value)
        {
            offset = value;
        }

        public void SetAngle(float value)
        {
            angle = value;
        }

        public void SetSelfOriginOffsetPercent(Vector2 value)
        {
            self_origin_offset_percent = value;
        }

        public void SetScreenOriginOffsetPercent(Vector2 value)
        {
            screen_origin_offset_percent = value;
        }

        public Vector2 GetOffset()
        {
            return offset;
        }

        public float GetAngle()
        {
            return angle;
        }

        public Vector2 GetSelfOriginOffsetPercent()
        {
            return self_origin_offset_percent;
        }

        public Vector2 GetScreenOriginOffsetPercent()
        {
            return screen_origin_offset_percent;
        }
    }
}