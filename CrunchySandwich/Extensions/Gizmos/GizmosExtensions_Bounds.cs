using System;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public partial class GizmosExtensions
    {
        static public void DrawBounds(Bounds bounds)
        {
            DrawWireCube(bounds);
        }
    }
}