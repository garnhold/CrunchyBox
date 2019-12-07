using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    public class ConvexPolygon
    {
        private HashSet<Vector2> vertexs;

        private bool is_dirty;
        private Vector2 center;
        private List<Face> faces;

        private void Validate()
        {
            if (is_dirty)
            {
                is_dirty = false;

                center = vertexs.Average();
                faces.Set(
                    vertexs
                        .Sort(v => -(v - center).GetAngleInDegrees())
                        .CloseLoop()
                        .ConvertConnections((v0, v1) => FaceExtensions.CreatePointsAndInsidePoint(v0, v1, center))
                );
            }
        }

        public ConvexPolygon()
        {
            vertexs = new HashSet<Vector2>();

            is_dirty = true;
            center = Vector2.zero;
            faces = new List<Face>();
        }

        public ConvexPolygon(IEnumerable<Vector2> v) : this()
        {
            this.AddVertexs(v);
        }
        public ConvexPolygon(params Vector2[] v) : this((IEnumerable<Vector2>)v) { }

        public void Clear()
        {
            vertexs.Clear();

            is_dirty = true;
            center = Vector2.zero;
            faces.Clear();
        }

        public void AddVertex(Vector2 vertex)
        {
            vertexs.Add(vertex);

            is_dirty = true;
        }

        public Vector2 GetCenter()
        {
            Validate();
            return center;
        }

        public IEnumerable<Face> GetFaces()
        {
            Validate();
            return faces;
        }
    }
}