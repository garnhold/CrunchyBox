using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
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
            return vertex_loops.ConvertGrouped(i => i);
        }
        
        public IEnumerable<IEnumerable<Face>> BuildFaceLoops()
        {
            return GetVertexLoops().ConvertGrouped(l => 
                l.CloseLoop().ConvertConnections((v0, v1) => FaceExtensions.CreatePoints(v0, v1))
            );
        }
        
        public IEnumerable<PolygonTriangle> BuildPolygonTriangles()
        {
            bool is_work_progressing;
            List<Face> face_loop = new List<Face>();

            foreach (IEnumerable<Face> face_loop_iter in BuildFaceLoops())
            {
                is_work_progressing = true;
                face_loop.Set(face_loop_iter);

                while (face_loop.IsNotEmpty() && is_work_progressing)
                {
                    is_work_progressing = false;

                    for (int i = 0; i < face_loop.Count; i++)
                    {
                        Face added_face;
                        Triangle2 added_triangle;

                        int index1 = face_loop.GetLoopedIndex(i);
                        int index2 = face_loop.GetLoopedIndex(i + 1);

                        Face f1 = face_loop[index1];
                        Face f2 = face_loop[index2];

                        if (f1.TryCreateTriangle(f2, out added_triangle, out added_face))
                        {
                            PolygonTriangle polygon_triangle = new PolygonTriangle(added_triangle);
                            
                            if (
                                faces.Convert(f => f.GetFace().v0)
                                    .AreNone(p => polygon_triangle.Contains(p, -float.Epsilon))
                            )
                            {
                                yield return polygon_triangle;
                                face_loop[index1] = added_face.GetFlipped();
                                face_loop.RemoveAt(index2);

                                is_work_progressing = true;
                            }
                        }
                    }
                }
            }
        }
    }
}