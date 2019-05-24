using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class MeshBuilderExtensions_Quad
    {
        static public void AddQuad(this MeshBuilder item, Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3)
        {
            item.AddTriangle(v0, v1, v2);
            item.AddTriangle(v2, v3, v0);
        }
    }
}