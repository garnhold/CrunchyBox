using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class TransformExtensions_Spacar_Interpolate
    {
        static public void InterpolateSpacarPosition(this Transform item, Vector3 target, float amount)
        {
            item.SetSpacarPosition(item.GetSpacarPosition().GetInterpolate(target, amount));
        }
        static public void InterpolateLocalSpacarPosition(this Transform item, Vector3 target, float amount)
        {
            item.SetLocalSpacarPosition(item.GetLocalSpacarPosition().GetInterpolate(target, amount));
        }

        static public void InterpolateSpacarForward(this Transform item, Vector3 target, float amount)
        {
            item.SetSpacarForward(item.GetSpacarForward().GetDirectionInterpolate(target, amount));
        }
        static public void InterpolateSpacarUp(this Transform item, Vector3 target, float amount)
        {
            item.SetSpacarUp(item.GetSpacarUp().GetDirectionInterpolate(target, amount));
        }

        static public void InterpolateSpacarQuaternion(this Transform item, Quaternion target, float amount)
        {
            item.SetSpacarQuaternion(item.GetSpacarQuaternion().GetInterpolate(target, amount));
        }
        static public void InterpolateLocalSpacarQuaternion(this Transform item, Quaternion target, float amount)
        {
            item.SetLocalSpacarQuaternion(item.GetLocalSpacarQuaternion().GetInterpolate(target, amount));
        }

        static public void InterpolateSpacarScale(this Transform item, Vector3 target, float amount)
        {
            item.SetSpacarScale(item.GetSpacarScale().GetInterpolate(target, amount));
        }
        static public void InterpolateLocalSpacarScale(this Transform item, Vector3 target, float amount)
        {
            item.SetLocalSpacarScale(item.GetLocalSpacarScale().GetInterpolate(target, amount));
        }

        static public void InterpolateSpacarScale(this Transform item, float target, float amount)
        {
            item.InterpolateSpacarScale(new Vector3(target, target, target), amount);
        }
        static public void InterpolateLocalSpacarScale(this Transform item, float target, float amount)
        {
            item.InterpolateLocalSpacarScale(new Vector3(target, target, target), amount);
        }
    }
}