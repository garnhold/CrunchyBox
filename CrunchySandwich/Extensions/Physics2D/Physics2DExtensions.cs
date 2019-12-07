using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public partial class Physics2DExtensions
    {
        static private readonly ArrayPool<Collider2D> COLLIDER_POOL = new ArrayPool<Collider2D>(32);
        static private readonly ArrayPool<RaycastHit2D> RAYCAST_HIT_POOL = new ArrayPool<RaycastHit2D>(32);
        static private readonly ArrayPool<ContactPoint2D> CONTACT_POINT_POOL = new ArrayPool<ContactPoint2D>(32);
    }
}