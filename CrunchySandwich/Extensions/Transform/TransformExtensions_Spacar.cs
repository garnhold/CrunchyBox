﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class TransformExtensions_Spacar
    {
        static public void SetSpacarPosition(this Transform item, Vector3 position)
        {
            item.position = position;
        }
        static public void SetLocalSpacarPosition(this Transform item, Vector3 position)
        {
            item.localPosition = position;
        }

        static public void SetSpacarRotation(this Transform item, Vector3 angles)
        {
            item.eulerAngles = angles;
        }
        static public void SetLocalSpacarRotation(this Transform item, Vector3 angles)
        {
            item.localEulerAngles = angles;
        }

        static public void SetSpacarQuaternion(this Transform item, Quaternion quaternion)
        {
            item.rotation = quaternion;
        }
        static public void SetLocalSpacarQuaternion(this Transform item, Quaternion quaternion)
        {
            item.localRotation = quaternion;
        }

        static public void SetSpacarScale(this Transform item, Vector3 scale)
        {
            if (item.parent != null)
                item.localScale = scale.GetComponentDivide(item.parent.lossyScale);
            else
                item.localScale = scale;
        }
        static public void SetSpacarScale(this Transform item, float scale)
        {
            item.SetSpacarScale(new Vector3(scale, scale, scale));
        }
        static public void SetLocalSpacarScale(this Transform item, Vector3 scale)
        {
            item.localScale = scale;
        }
        static public void SetLocalSpacarScale(this Transform item, float scale)
        {
            item.SetLocalSpacarScale(new Vector3(scale, scale));
        }

        static public Vector3 GetSpacarPosition(this Transform item)
        {
            return item.position;
        }
        static public Vector3 GetLocalSpacarPosition(this Transform item)
        {
            return item.localPosition;
        }

        static public Vector3 GetSpacarRotation(this Transform item)
        {
            return item.eulerAngles;
        }
        static public Vector3 GetLocalSpacarRotation(this Transform item)
        {
            return item.localEulerAngles;
        }

        static public Quaternion GetSpacarQuaternion(this Transform item)
        {
            return item.rotation;
        }
        static public Quaternion GetLocalSpacarQuaternion(this Transform item)
        {
            return item.localRotation;
        }

        static public Vector3 GetSpacarScale(this Transform item)
        {
            return item.lossyScale;
        }
        static public Vector3 GetLocalSpacarScale(this Transform item)
        {
            return item.localScale;
        }
    }
}