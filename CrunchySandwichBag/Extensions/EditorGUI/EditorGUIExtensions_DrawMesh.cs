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
        static private OperationCache<Material> DRAW_COLORED_MESH_MATERIAL = new OperationCache<Material>(delegate() {
            return MaterialExtensions.CreateUnlitColorMaterial(Color.white);
        });
        static public void DrawColoredMesh(Mesh mesh, Color color)
        {
            Material material = DRAW_COLORED_MESH_MATERIAL.Fetch();

            material.SetMainColor(color);
            material.SetPass(0);
            Graphics.DrawMeshNow(mesh, GUI.matrix);
        }
    }
}