using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

using UnityEngine;

namespace CrunchySandwich
{
    static public class MeshExtensions_CalculateUV
    {
        static public void CalculateUVs(this Mesh item)
        {
            Vector2[] uvs = new Vector2[item.vertexCount];

            for (int i = 0; i < item.vertexCount; i++)
            {
                Vector3 normal = item.normals[i];
                Vector3 position = item.vertices[i];

                PlaneSpace place = new PlaneSpace(PlaneExtensions.CreateNormalAndDistance(normal, 0.0f));

                uvs[i] = place.ProjectPoint(position);
            }

            item.uv = uvs;
        }
    }
}