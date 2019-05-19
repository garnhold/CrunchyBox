using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class MeshBuilderExtensions_Seal
    {
        static public void Seal(this MeshBuilder item, Plane plane, float edge_tolerance, float plane_tolerance)
        {
            FaceCloud faces = new FaceCloud(edge_tolerance);
            PlaneSpace plane_space = plane.GetPlaneSpace();

            foreach (Edge3 edge in item.GetTriangles().GetEdges())
            {
                if(plane.IsCoplanar(edge, plane_tolerance))
                    faces.AddFace(FaceExtensions.CreateEdge(plane_space.ProjectEdge(edge)));
            }

            item.AddTriangles(
                plane_space.InflateTriangles(faces.Tesselate())
                    .Convert(t => t.GetReversedWinding())
            );
        }
    }
}