using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public partial class GUIExtensions
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