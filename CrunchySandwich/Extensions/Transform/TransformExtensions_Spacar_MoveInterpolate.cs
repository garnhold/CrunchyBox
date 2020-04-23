using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class TransformExtensions_Spacar_MoveInterpolate
    {
        static public bool MoveInterpolateSpacarPosition(this Transform item, Vector3 target, float amount)
        {
            Vector3 output;
            bool result = item.GetSpacarPosition().GetMoveInterpolate(target, amount, out output);

            item.SetSpacarPosition(output);
            return result;
        }
        static public bool MoveInterpolateLocalSpacarPosition(this Transform item, Vector3 target, float amount)
        {
            Vector3 output;
            bool result = item.GetLocalSpacarPosition().GetMoveInterpolate(target, amount, out output);

            item.SetLocalSpacarPosition(output);
            return result;
        }

        static public bool MoveInterpolateSpacarForward(this Transform item, Vector3 target, float amount)
        {
            Vector3 output;
            bool result = item.GetSpacarForward().GetDirectionMoveInterpolate(target, amount, out output);

            item.SetSpacarForward(output);
            return result;
        }
        static public bool MoveInterpolateSpacarUp(this Transform item, Vector3 target, float amount)
        {
            Vector3 output;
            bool result = item.GetSpacarUp().GetDirectionMoveInterpolate(target, amount, out output);

            item.SetSpacarUp(output);
            return result;
        }

        static public bool MoveInterpolateSpacarQuaternion(this Transform item, Quaternion target, float amount)
        {
            Quaternion output;
            bool result = item.GetSpacarQuaternion().GetMoveInterpolate(target, amount, out output);

            item.SetSpacarQuaternion(output);
            return result;
        }
        static public bool MoveInterpolateLocalSpacarQuaternion(this Transform item, Quaternion target, float amount)
        {
            Quaternion output;
            bool result = item.GetLocalSpacarQuaternion().GetMoveInterpolate(target, amount, out output);

            item.SetLocalSpacarQuaternion(output);
            return result;
        }

        static public bool MoveInterpolateSpacarScale(this Transform item, Vector3 target, float amount)
        {
            Vector3 output;
            bool result = item.GetSpacarScale().GetMoveInterpolate(target, amount, out output);

            item.SetSpacarScale(output);
            return result;
        }
        static public bool MoveInterpolateLocalSpacarScale(this Transform item, Vector3 target, float amount)
        {
            Vector3 output;
            bool result = item.GetLocalSpacarScale().GetMoveInterpolate(target, amount, out output);

            item.SetLocalSpacarScale(output);
            return result;
        }

        static public bool MoveInterpolateSpacarScale(this Transform item, float target, float amount)
        {
            return item.MoveInterpolateSpacarScale(new Vector3(target, target), amount);
        }
        static public bool MoveInterpolateLocalSpacarScale(this Transform item, float target, float amount)
        {
            return item.MoveInterpolateLocalSpacarScale(new Vector3(target, target), amount);
        }
    }
}