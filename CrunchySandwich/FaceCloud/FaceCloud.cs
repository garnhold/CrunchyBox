using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    public class FaceCloud
    {
        private List<FaceCloudFace> faces;
        private float connection_tolerance;

        private bool is_dirty;
        private List<List<Vector2>> vertex_loops;

        private void BuildVertexLoops()
        {
            FaceCloudFace face;

            vertex_loops.Clear();
            faces.Process(f => f.Reset());

            while (faces.TryFindFirst(f => f.IsNotUsed(), out face))
                BuildVertexLoop(face, vertex_loops.AddAndGet(new List<Vector2>()));
        }
        private void BuildVertexLoop(FaceCloudFace face, List<Vector2> vertex_loop)
        {
            double rating = 0.0;
            double maximum_rating = connection_tolerance * connection_tolerance;

            while (face != null && rating <= maximum_rating)
            {
                vertex_loop.Add(face.GetFace().v0);
                face.Use();

                face = faces.Narrow(f => f.IsNotUsed())
                    .FindLowestRated(f => face.GetFace().v1.GetSquaredDistanceTo(f.GetFace().v0), out rating);
            }
        }
        
        private void Validate()
        {
            if (is_dirty)
            {
                is_dirty = false;

                BuildVertexLoops();
            }
        }

        public FaceCloud(float c)
        {
            faces = new List<FaceCloudFace>();
            connection_tolerance = c;

            is_dirty = true;
            vertex_loops = new List<List<Vector2>>();
        }
        
        public void AddFace(Face face)
        {
            faces.Add(new FaceCloudFace(face));
            is_dirty = true;
        }
        
        public IEnumerable<IEnumerable<Vector2>> GetVertexLoops()
        {
            Validate();

            return vertex_loops.Convert(i => (IEnumerable<Vector2>)i);
        }
    }
}