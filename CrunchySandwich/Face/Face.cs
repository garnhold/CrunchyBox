using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    public struct Face
    {
        public readonly Vector2 v0;
        public readonly Vector2 v1;

        public readonly Vector2 normal;

        public Face(Vector2 nv0, Vector2 nv1)
        {
            v0 = nv0;
            v1 = nv1;

            normal = (nv1 - nv0).GetNormalizedNormal();
        }
    }
}