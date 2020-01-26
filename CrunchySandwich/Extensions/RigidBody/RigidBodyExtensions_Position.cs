using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class RigidBodyExtensions_Position
    {
        static public void AdjustPosition(this Rigidbody item, Vector3 amount)
        {
            item.MovePosition(item.position + amount);
        }

        static public void AdjustPosition(this Rigidbody item, Vector3 amount, float max_distance)
        {
            item.AdjustPosition(amount.BindMagnitudeBelow(max_distance));
        }

        static public void AdjustToPosition(this Rigidbody item, Vector3 position, float max_distance)
        {
            item.AdjustPosition(position - item.position, max_distance);
        }
    }
}