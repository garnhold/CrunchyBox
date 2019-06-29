using System;

using CrunchyDough;
using UnityEngine;

namespace CrunchySandwich
{
    static public partial class GUIUtilityExtensions
    {
        static public void ScaleAroundPivot(float scale, Vector2 pivot)
        {
            GUIUtility.ScaleAroundPivot(new Vector2(scale, scale), pivot);
        }
    }
}