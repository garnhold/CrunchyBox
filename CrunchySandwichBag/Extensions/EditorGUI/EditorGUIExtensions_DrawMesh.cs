using System;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    static public partial class EditorGUIExtensions
    {
        static public void DrawColoredMesh(Mesh mesh, Color color)
        {
            Material material = MaterialExtensions.CreateUnlitColorMaterial(Color.white);

            material.SetMainColor(color);
            material.SetPass(0);
            Graphics.DrawMeshNow(mesh, GUI.matrix);
        }
    }
}