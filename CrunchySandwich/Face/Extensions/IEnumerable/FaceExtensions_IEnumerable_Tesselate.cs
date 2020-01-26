using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class FaceExtensions_IEnumerable_Tesselate
    {
        static public IEnumerable<PolygonTriangle> TesselateLoop(this IEnumerable<Face> item)
        {
            bool is_work_progressing = true;
            List<Face> faces = item.ToList();
            List<Face> remaining_faces = item.ToList();

            while (remaining_faces.IsNotEmpty() && is_work_progressing)
            {
                is_work_progressing = false;

                for (int i = 0; i < remaining_faces.Count; i++)
                {
                    Face added_face;
                    Triangle2 added_triangle;

                    int index1 = remaining_faces.GetLoopedIndex(i);
                    int index2 = remaining_faces.GetLoopedIndex(i + 1);

                    Face f1 = remaining_faces[index1];
                    Face f2 = remaining_faces[index2];

                    if (f1.TryCreateTriangle(f2, out added_triangle, out added_face))
                    {
                        PolygonTriangle polygon_triangle = new PolygonTriangle(added_triangle);

                        if (faces.Convert(f => f.v0).AreNone(p => polygon_triangle.Contains(p, -float.Epsilon)))
                        {
                            yield return polygon_triangle;
                            remaining_faces[index1] = added_face.GetFlipped();
                            remaining_faces.RemoveAt(index2);

                            is_work_progressing = true;
                        }
                    }
                }
            }
        }
    }
}