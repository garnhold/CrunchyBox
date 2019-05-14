using System;

using UnityEngine;

namespace CrunchySandwich
{
    public struct TerrainSample
    {
        private float height;
        private Vector3 normal;

        public TerrainSample(float h, Vector3 n)
        {
            height = h;
            normal = n;
        }

        public float GetHeight()
        {
            return height;
        }

        public Vector3 GetNormal()
        {
            return normal;
        }

        public float GetSurfaceAngle()
        {
            return Vector3.Angle(Vector3.up, normal);
        }
    }
}