using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class TransformExtensions_Spacar_MoveTowards
    {
        static public bool MoveTowardsSpacarPosition(this Transform item, Vector3 target, Vector3 amount)
        {
            Vector3 output;
            bool result = item.GetSpacarPosition().GetMoveTowards(target, amount, out output);

            item.SetSpacarPosition(output);
            return result;
        }
        static public bool MoveTowardsLocalSpacarPosition(this Transform item, Vector3 target, Vector3 amount)
        {
            Vector3 output;
            bool result = item.GetLocalSpacarPosition().GetMoveTowards(target, amount, out output);

            item.SetLocalSpacarPosition(output);
            return result;
        }

        static public bool MoveTowardsSpacarPosition(this Transform item, Vector3 target, float amount)
        {
            Vector3 output;
            bool result = item.GetSpacarPosition().GetMoveTowards(target, amount, out output);

            item.SetSpacarPosition(output);
            return result;
        }
        static public bool MoveTowardsLocalSpacarPosition(this Transform item, Vector3 target, float amount)
        {
            Vector3 output;
            bool result = item.GetLocalSpacarPosition().GetMoveTowards(target, amount, out output);

            item.SetLocalSpacarPosition(output);
            return result;
        }

        static public bool MoveTowardsSpacarScale(this Transform item, Vector3 target, Vector3 amount)
        {
            Vector3 output;
            bool result = item.GetSpacarScale().GetMoveTowards(target, amount, out output);

            item.SetSpacarScale(output);
            return result;
        }
        static public bool MoveTowardsLocalSpacarScale(this Transform item, Vector3 target, Vector3 amount)
        {
            Vector3 output;
            bool result = item.GetLocalSpacarScale().GetMoveTowards(target, amount, out output);

            item.SetLocalSpacarScale(output);
            return result;
        }

        static public bool MoveTowardsSpacarScale(this Transform item, float target, float amount)
        {
            return item.MoveTowardsSpacarScale(new Vector3(target, target, target), new Vector3(amount, amount, amount));
        }
        static public bool MoveTowardsLocalSpacarScale(this Transform item, float target, float amount)
        {
            return item.MoveTowardsLocalSpacarScale(new Vector3(target, target, target), new Vector3(amount, amount, amount));
        }
    }
}