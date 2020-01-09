using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public class MeshDissectorExtensions_Chunk
    {
        static public Mesh GetChunk(this MeshDissector item, Bounds bounds)
        {
            MeshBuilder builder = new MeshBuilder();

            builder.AddChunk(item, bounds);
            return builder.BuildMesh();
        }

        static public Mesh GetChunk(this MeshDissector item, Plane plane)
        {
            MeshBuilder builder = new MeshBuilder();

            builder.AddChunk(item, plane);
            return builder.BuildMesh();
        }
    }
}