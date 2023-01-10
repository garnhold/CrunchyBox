using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public class MeshExtensions_CalculateUV
    {
        static public void CalculateUVs(this Mesh item, float scale=1.0f)
        {
            Vector2[] uvs = new Vector2[item.vertexCount];

            for (int i = 0; i < item.vertexCount; i++)
            {
                Vector3 normal = item.normals[i];
                Vector3 position = item.vertices[i];

                PlaneSpace place = new PlaneSpace(PlaneExtensions.CreateNormalAndDistance(normal, 0.0f));

                uvs[i] = place.DeflatePoint(position) * scale;
            }

            item.uv = uvs;
        }
    }
}