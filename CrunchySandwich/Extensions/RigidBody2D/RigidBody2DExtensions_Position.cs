using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class RigidBody2DExtensions_Position
    {
        static public void AdjustPosition(this Rigidbody2D item, Vector2 amount)
        {
            item.MovePosition(item.position + amount);
        }

        static public void AdjustPosition(this Rigidbody2D item, Vector2 amount, float max_distance)
        {
            item.AdjustPosition(amount.BindMagnitudeBelow(max_distance));
        }

        static public void AdjustToPosition(this Rigidbody2D item, Vector2 position, float max_distance)
        {
            item.AdjustPosition(position - item.position, max_distance);
        }
    }
}