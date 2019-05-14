using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class RigidBody2DExtensions_Rotation
    {
        static public void AdjustRotation(this Rigidbody2D item, float amount)
        {
            item.MoveRotation(item.rotation + amount);
        }

        static public void AdjustToRotation(this Rigidbody2D item, float angle)
        {
            item.MoveRotation(angle);
        }
    }
}