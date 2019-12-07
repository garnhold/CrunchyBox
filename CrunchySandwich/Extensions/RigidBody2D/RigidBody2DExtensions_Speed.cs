using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class RigidBody2DExtensions_Speed
    {
        static public float GetSpeed(this Rigidbody2D item)
        {
            return item.velocity.GetMagnitude();
        }
    }
}