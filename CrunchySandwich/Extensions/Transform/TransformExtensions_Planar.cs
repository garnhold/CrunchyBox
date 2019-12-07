using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class TransformExtensions_Planar
    {
        static public void SetPlanarPosition(this Transform item, Vector2 position)
        {
            item.SetSpacarPosition(item.position.GetWithXY(position));
        }
        static public void SetLocalPlanarPosition(this Transform item, Vector2 position)
        {
            item.SetLocalSpacarPosition(item.localPosition.GetWithXY(position));
        }
        static public void SetOffsetPlanarPosition(this Transform item, Vector2 position)
        {
            item.SetPlanarPosition(item.GetParentPlanarPosition() + position);
        }

        static public void SetPlanarRotation(this Transform item, float angle)
        {
            item.SetSpacarRotation(item.GetSpacarRotation().GetWithZ(angle));
        }
        static public void SetLocalPlanarRotation(this Transform item, float angle)
        {
            item.SetLocalSpacarRotation(item.GetLocalSpacarRotation().GetWithZ(angle));
        }

        static public void SetPlanarScale(this Transform item, Vector2 scale)
        {
            item.SetSpacarScale(item.GetSpacarScale().GetWithXY(scale));
        }
        static public void SetPlanarScale(this Transform item, float scale)
        {
            item.SetPlanarScale(new Vector2(scale, scale));
        }
        static public void SetLocalPlanarScale(this Transform item, Vector2 scale)
        {
            item.localScale = item.localScale.GetWithXY(scale);
        }
        static public void SetLocalPlanarScale(this Transform item, float scale)
        {
            item.SetLocalPlanarScale(new Vector2(scale, scale));
        }

        static public Vector2 GetPlanarPosition(this Transform item)
        {
            return item.position.GetPlanar();
        }
        static public Vector2 GetLocalPlanarPosition(this Transform item)
        {
            return item.localPosition.GetPlanar();
        }
        static public Vector2 GetOffsetPlanarPosition(this Transform item)
        {
            return item.GetPlanarPosition() - item.GetParentPlanarPosition();
        }

        static public float GetPlanarRotation(this Transform item)
        {
            return item.eulerAngles.z;
        }
        static public float GetLocalPlanarRotation(this Transform item)
        {
            return item.localEulerAngles.z;
        }

        static public Vector2 GetPlanarScale(this Transform item)
        {
            return item.lossyScale.GetPlanar();
        }
        static public Vector2 GetLocalPlanarScale(this Transform item)
        {
            return item.localScale.GetPlanar();
        }
    }
}