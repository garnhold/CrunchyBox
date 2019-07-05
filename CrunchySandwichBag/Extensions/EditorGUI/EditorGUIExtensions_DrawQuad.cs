using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    static public partial class EditorGUIExtensions
    {
        static public void DrawQuad(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Color color)
        {
            Mesh mesh = MeshExtensions.CreateCornerQuad();

            mesh.vertices = new Vector3[]{
                p1, p2, p3, p4
            };

            DrawColoredMesh(mesh, color);
        }
    }
}