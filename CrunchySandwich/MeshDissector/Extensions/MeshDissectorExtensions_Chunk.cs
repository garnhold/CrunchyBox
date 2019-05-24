using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

using UnityEngine;

namespace CrunchySandwich
{
    static public class MeshDissectorExtensions_Chunk
    {
        static public Mesh GetChunk(this MeshDissector item, Bounds bounds)
        {
            MeshBuilder builder = new MeshBuilder_Smooth();

            builder.AddChunk(item, bounds);
            return builder.BuildMesh();
        }

        static public Mesh GetChunk(this MeshDissector item, Plane plane)
        {
            MeshBuilder builder = new MeshBuilder_Smooth();

            builder.AddChunk(item, plane);
            return builder.BuildMesh();
        }
    }
}