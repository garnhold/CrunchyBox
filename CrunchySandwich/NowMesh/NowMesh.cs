using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    public class NowMesh
    {
        private Mesh mesh;
        private Material material;

        public NowMesh(Mesh me, Material ma)
        {
            mesh = me;
            material = ma;
        }

        public NowMesh() : this(null, null) { }

        public void Draw(Matrix4x4 matrix)
        {
            material.SetPass(0);
            Graphics.DrawMeshNow(mesh, matrix);
        }
        public void Draw(Vector3 point, Quaternion rotation, Vector3 scale)
        {
            Draw(Matrix4x4.TRS(point, rotation, scale));
        }
        public void Draw(Vector3 point, Vector3 rotation, Vector3 scale)
        {
            Draw(point, Quaternion.Euler(rotation), scale);
        }

        public void SetMesh(Mesh m)
        {
            mesh = m;
        }

        public void SetMaterial(Material m)
        {
            material = m;
        }

        public Mesh GetMesh()
        {
            return mesh;
        }

        public Material GetMaterial()
        {
            return material;
        }
    }
}