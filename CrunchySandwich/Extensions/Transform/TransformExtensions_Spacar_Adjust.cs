using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class TransformExtensions_Spacar_Adjust
    {
        static public void AdjustSpacarPosition(this Transform item, Vector3 amount)
        {
            item.SetSpacarPosition(item.GetSpacarPosition() + amount);
        }
        static public void AdjustLocalSpacarPosition(this Transform item, Vector3 amount)
        {
            item.SetLocalSpacarPosition(item.GetLocalSpacarPosition() + amount);
        }

        static public void AdjustSpacarRotation(this Transform item, Vector3 amount)
        {
            item.SetSpacarRotation(item.GetSpacarRotation() + amount);
        }
        static public void AdjustLocalSpacarRotation(this Transform item, Vector3 amount)
        {
            item.SetLocalSpacarRotation(item.GetLocalSpacarRotation() + amount);
        }

        static public void AdjustSpacarQuaternion(this Transform item, Quaternion amount)
        {
            item.SetSpacarQuaternion(item.GetSpacarQuaternion() * amount);
        }
        static public void AdjustLocalSpacarQuaternion(this Transform item, Quaternion amount)
        {
            item.SetLocalSpacarQuaternion(item.GetLocalSpacarQuaternion() * amount);
        }

        static public void AdjustSpacarScale(this Transform item, Vector3 amount)
        {
            item.SetSpacarScale(item.GetSpacarScale() + amount);
        }
        static public void AdjustLocalSpacarScale(this Transform item, Vector3 amount)
        {
            item.SetLocalSpacarScale(item.GetLocalSpacarScale() + amount);
        }
    }
}