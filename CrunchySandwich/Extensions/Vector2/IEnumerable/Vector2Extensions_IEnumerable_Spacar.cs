using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Vector2Extensions_IEnumerable_Spacar
    {
        static public IEnumerable<Vector3> GetSpacar(this IEnumerable<Vector2> item, float z)
        {
            return item.Convert(v => v.GetSpacar(z));
        }
        static public IEnumerable<Vector3> GetSpacar(this IEnumerable<Vector2> item)
        {
            return item.GetSpacar(0.0f);
        }
    }
}