using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class MeshBuilderExtensions_Seal
    {
        static public void Seal(this MeshBuilder item, Plane plane, float edge_tolerance, float plane_tolerance)
        {
            FaceCloud faces = new FaceCloud(edge_tolerance);
            PlaneSpace plane_space = plane.GetPlaneSpace();

            foreach (LineSegment3 edge in item.GetTriangles().Convert(t => t.GetEdges()).Flatten().Unique())
            {
                if(plane.IsCoplanar(edge, plane_tolerance))
                    faces.AddFace(plane_space.DeflateLineSegment(edge).GetFace());
            }

            item.AddTriangles(
                plane_space.InflateTriangles(faces.Tesselate())
                    .Convert(t => t.GetReversedWinding())
            );
        }
    }
}