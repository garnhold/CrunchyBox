using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

using UnityEngine;

namespace CrunchySandwich
{
    static public partial class GUIExtensions
    {
        static public void DrawLine(Vector2 p1, Vector2 p2, float line_thickness = 1.0f)
        {
            Vector2 diff = p2 - p1;

            float angle = diff.GetAngleInDegrees();
            float distance = diff.GetMagnitude();

            GUIUtility.RotateAroundPivot(angle, p1);
                GUI.DrawTexture(
                    p1.GetRect().GetEnlarged(0.0f, line_thickness*0.5f, distance, line_thickness*0.5f),
                    GetWhitePixelTexture()
                );
            GUIUtility.RotateAroundPivot(-angle, p1);
        }
    }
}