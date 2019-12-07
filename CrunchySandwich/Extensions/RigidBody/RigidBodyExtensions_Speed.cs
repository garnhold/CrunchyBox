using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class RigidBodyExtensions_Speed
    {
        static public float GetSpeed(this Rigidbody item)
        {
            return item.velocity.GetMagnitude();
        }
    }
}