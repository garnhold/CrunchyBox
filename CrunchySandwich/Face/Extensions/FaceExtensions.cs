using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class FaceExtensions
    {
        static public Face CreatePoints(Vector2 v0, Vector2 v1)
        {
            return new Face(v0, v1);
        }

        static public Face CreatePointsAndInsidePoint(Vector2 v0, Vector2 v1, Vector2 inside)
        {
            Face face = CreatePoints(v0, v1);

            if (face.IsInside(inside))
                return face;

            return face.GetFlipped();
        }

        static public Face CreatePointsAndComplyingVector(Vector2 v0, Vector2 v1, Vector2 vector)
        {
            Face face = CreatePoints(v0, v1);

            if (face.IsComplyingVector(vector))
                return face;

            return face.GetFlipped();
        }
    }
}