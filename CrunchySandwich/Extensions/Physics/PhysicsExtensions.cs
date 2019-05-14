using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public partial class PhysicsExtensions
    {
        static private readonly ArrayPool<Collider> COLLIDER_POOL = new ArrayPool<Collider>(16);
    }
}