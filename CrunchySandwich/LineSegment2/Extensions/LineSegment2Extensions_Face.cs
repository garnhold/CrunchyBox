using System;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class LineSegment2Extensions_Face
    {
        static public Face GetFace(this LineSegment2 item)
        {
            return FaceExtensions.CreatePoints(item.v0, item.v1);
        }
    }
}