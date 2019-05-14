using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class ContactPoint2DExtensions_Penetration
    {
        static public Vector2 GetPenetration(this ContactPoint2D item)
        {
            return item.normal * item.separation;
        }
    }
}