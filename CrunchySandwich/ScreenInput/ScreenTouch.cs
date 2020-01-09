using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    public struct ScreenTouch
    {
        public readonly int id;
        public readonly Vector2 position;

        public ScreenTouch(int i, Vector2 p)
        {
            id = i;
            position = p;
        }

        public ScreenTouch(Touch t) : this(t.fingerId, t.position) { }
    }
}