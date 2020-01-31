using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class TransformExtensions_Arear
    {
        static public void SetArearPosition(this Transform item, Vector2 position)
        {
            item.SetSpacarPosition(item.position.GetWithXZ(position));
        }
        static public void SetLocalArearPosition(this Transform item, Vector2 position)
        {
            item.SetLocalSpacarPosition(item.localPosition.GetWithXZ(position));
        }
        static public void SetOffsetArearPosition(this Transform item, Vector2 position)
        {
            item.SetArearPosition(item.GetParentArearPosition() + position);
        }

        static public void SetArearRotation(this Transform item, float angle)
        {
            item.SetSpacarRotation(item.GetSpacarRotation().GetWithY(angle));
        }
        static public void SetLocalArearRotation(this Transform item, float angle)
        {
            item.SetLocalSpacarRotation(item.GetLocalSpacarRotation().GetWithY(angle));
        }

        static public void SetArearScale(this Transform item, Vector2 scale)
        {
            item.SetSpacarScale(item.GetSpacarScale().GetWithXZ(scale));
        }
        static public void SetArearScale(this Transform item, float scale)
        {
            item.SetArearScale(new Vector2(scale, scale));
        }
        static public void SetLocalArearScale(this Transform item, Vector2 scale)
        {
            item.localScale = item.localScale.GetWithXZ(scale);
        }
        static public void SetLocalArearScale(this Transform item, float scale)
        {
            item.SetLocalArearScale(new Vector2(scale, scale));
        }

        static public Vector2 GetArearPosition(this Transform item)
        {
            return item.position.GetArear();
        }
        static public Vector2 GetLocalArearPosition(this Transform item)
        {
            return item.localPosition.GetArear();
        }
        static public Vector2 GetOffsetArearPosition(this Transform item)
        {
            return item.GetArearPosition() - item.GetParentArearPosition();
        }

        static public float GetArearRotation(this Transform item)
        {
            return item.eulerAngles.y;
        }
        static public float GetLocalArearRotation(this Transform item)
        {
            return item.localEulerAngles.y;
        }

        static public Vector2 GetArearScale(this Transform item)
        {
            return item.lossyScale.GetArear();
        }
        static public Vector2 GetLocalArearScale(this Transform item)
        {
            return item.localScale.GetArear();
        }
    }
}