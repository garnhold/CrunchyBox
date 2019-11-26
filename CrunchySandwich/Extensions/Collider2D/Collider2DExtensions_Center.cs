using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Collider2DExtensions_Center
    {
        static public Vector2 GetLocalCenter(this Collider2D item)
        {
            return item.offset;
        }

        static public Vector2 GetCenter(this Collider2D item)
        {
            return item.transform.TransformPoint(item.GetLocalCenter());
        }
    }
}