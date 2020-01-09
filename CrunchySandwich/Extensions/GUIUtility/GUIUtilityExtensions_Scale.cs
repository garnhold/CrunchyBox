using System;

using Crunchy.Dough;
using UnityEngine;

namespace Crunchy.Sandwich
{
    static public partial class GUIUtilityExtensions
    {
        static public void ScaleAroundPivot(float scale, Vector2 pivot)
        {
            GUIUtility.ScaleAroundPivot(new Vector2(scale, scale), pivot);
        }
    }
}