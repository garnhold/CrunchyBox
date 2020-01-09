using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class TransformExtensions_Planar_MoveTowards
    {
        static public bool MoveTowardsPlanarPosition(this Transform item, Vector2 target, Vector2 amount)
        {
            Vector2 output;
            bool result = item.GetPlanarPosition().GetMoveTowards(target, amount, out output);

            item.SetPlanarPosition(output);
            return result;
        }
        static public bool MoveTowardsLocalPlanarPosition(this Transform item, Vector2 target, Vector2 amount)
        {
            Vector2 output;
            bool result = item.GetLocalPlanarPosition().GetMoveTowards(target, amount, out output);

            item.SetLocalPlanarPosition(output);
            return result;
        }

        static public bool MoveTowardsPlanarPosition(this Transform item, Vector2 target, float amount)
        {
            Vector2 output;
            bool result = item.GetPlanarPosition().GetMoveTowards(target, amount, out output);

            item.SetPlanarPosition(output);
            return result;
        }
        static public bool MoveTowardsLocalPlanarPosition(this Transform item, Vector2 target, float amount)
        {
            Vector2 output;
            bool result = item.GetLocalPlanarPosition().GetMoveTowards(target, amount, out output);

            item.SetLocalPlanarPosition(output);
            return result;
        }

        static public bool MoveTowardsPlanarRotation(this Transform item, float target, float amount)
        {
            float output;
            bool result = item.GetPlanarRotation().GetMoveTowardsAngleInDegrees(target, amount, out output);

            item.SetPlanarRotation(output);
            return result;
        }
        static public bool MoveTowardsLocalPlanarRotation(this Transform item, float target, float amount)
        {
            float output;
            bool result = item.GetLocalPlanarRotation().GetMoveTowardsAngleInDegrees(target, amount, out output);

            item.SetLocalPlanarRotation(output);
            return result;
        }

        static public bool MoveTowardsPlanarScale(this Transform item, Vector2 target, Vector2 amount)
        {
            Vector2 output;
            bool result = item.GetPlanarScale().GetMoveTowards(target, amount, out output);

            item.SetPlanarScale(output);
            return result;
        }
        static public bool MoveTowardsLocalPlanarScale(this Transform item, Vector2 target, Vector2 amount)
        {
            Vector2 output;
            bool result = item.GetLocalPlanarScale().GetMoveTowards(target, amount, out output);

            item.SetLocalPlanarScale(output);
            return result;
        }

        static public bool MoveTowardsPlanarScale(this Transform item, float target, float amount)
        {
            return item.MoveTowardsPlanarScale(new Vector2(target, target), new Vector2(amount, amount));
        }
        static public bool MoveTowardsLocalPlanarScale(this Transform item, float target, float amount)
        {
            return item.MoveTowardsLocalPlanarScale(new Vector2(target, target), new Vector2(amount, amount));
        }
    }
}