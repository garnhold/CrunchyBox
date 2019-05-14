using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Vector2Extensions_IEnumerable_Floats
    {
        static public IEnumerable<float> ConvertToFloats(this IEnumerable<Vector2> item)
        {
            foreach (Vector2 vector in item)
            {
                yield return vector.x;
                yield return vector.y;
            }
        }
    }
}