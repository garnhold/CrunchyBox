using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class AxisExtensions
    {
        static public Vector3 GetVector3(this Axis item, float primary, float secondary1, float secondary2)
        {
            switch (item)
            {
                case Axis.X: return new Vector3(primary, secondary1, secondary2);
                case Axis.Y: return new Vector3(secondary1, primary, secondary2);
                case Axis.Z: return new Vector3(secondary1, secondary2, primary);
            }

            return Vector3.zero;
        }

        static public Vector3 GetVector3(this Axis item)
        {
            return item.GetVector3(1.0f, 0.0f, 0.0f);
        }
    }
}