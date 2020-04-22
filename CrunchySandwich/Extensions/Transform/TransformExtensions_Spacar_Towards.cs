using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class TransformExtensions_Spacar_Towards
    {
        static public void TowardsSpacarPosition(this Transform item, Vector3 target, Vector3 amount)
        {
            item.SetSpacarPosition(item.GetSpacarPosition().GetTowards(target, amount));
        }
        static public void TowardsLocalSpacarPosition(this Transform item, Vector3 target, Vector3 amount)
        {
            item.SetLocalSpacarPosition(item.GetLocalSpacarPosition().GetTowards(target, amount));
        }

        static public void TowardsSpacarPosition(this Transform item, Vector3 target, float amount)
        {
            item.SetSpacarPosition(item.GetSpacarPosition().GetTowards(target, amount));
        }
        static public void TowardsLocalSpacarPosition(this Transform item, Vector3 target, float amount)
        {
            item.SetLocalSpacarPosition(item.GetLocalSpacarPosition().GetTowards(target, amount));
        }

        static public void TowardsSpacarScale(this Transform item, Vector3 target, Vector3 amount)
        {
            item.SetSpacarScale(item.GetSpacarScale().GetTowards(target, amount));
        }
        static public void TowardsLocalSpacarScale(this Transform item, Vector3 target, Vector3 amount)
        {
            item.SetLocalSpacarScale(item.GetLocalSpacarScale().GetTowards(target, amount));
        }

        static public void TowardsSpacarScale(this Transform item, float target, float amount)
        {
            item.TowardsSpacarScale(new Vector3(target, target, target), new Vector3(amount, amount, amount));
        }
        static public void TowardsLocalSpacarScale(this Transform item, float target, float amount)
        {
            item.TowardsLocalSpacarScale(new Vector3(target, target, target), new Vector3(amount, amount, amount));
        }
    }
}