using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class Vector2Extensions_Looped
    {
        static public Vector2 GetLooped(this Vector2 item, float length)
        {
            return new Vector2(item.x.GetLooped(length), item.y.GetLooped(length));
        }

        static public Vector2 GetLooped(this Vector2 item, Vector2 length)
        {
            return new Vector2(item.x.GetLooped(length.x), item.y.GetLooped(length.y));
        }
    }
}