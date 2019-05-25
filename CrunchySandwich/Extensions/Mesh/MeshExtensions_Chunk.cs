using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

using UnityEngine;

namespace CrunchySandwich
{
    static public class MeshExtensions_Chunk
    {
        static public Mesh GetChunk(this Mesh item, Bounds bounds)
        {
            MeshBuilder builder = new MeshBuilder();

            builder.AddChunk(item, bounds);
            return builder.BuildMesh();
        }

        static public Mesh GetChunk(this Mesh item, Plane plane)
        {
            MeshBuilder builder = new MeshBuilder();

            builder.AddChunk(item, plane);
            return builder.BuildMesh();
        }
    }
}