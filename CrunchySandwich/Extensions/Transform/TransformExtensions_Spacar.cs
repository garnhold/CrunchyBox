using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

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

        static public void SetSpacarXRotation(this Transform item, float angle)
        {
            item.SetSpacarRotation(item.GetSpacarRotation().GetWithX(angle));
        }
        static public void SetLocalSpacarXRotation(this Transform item, float angle)
        {
            item.SetLocalSpacarRotation(item.GetLocalSpacarRotation().GetWithX(angle));
        }

        static public void SetSpacarYRotation(this Transform item, float angle)
        {
            item.SetSpacarRotation(item.GetSpacarRotation().GetWithY(angle));
        }
        static public void SetLocalSpacarYRotation(this Transform item, float angle)
        {
            item.SetLocalSpacarRotation(item.GetLocalSpacarRotation().GetWithY(angle));
        }

        static public void SetSpacarZRotation(this Transform item, float angle)
        {
            item.SetSpacarRotation(item.GetSpacarRotation().GetWithZ(angle));
        }
        static public void SetLocalSpacarZRotation(this Transform item, float angle)
        {
            item.SetLocalSpacarRotation(item.GetLocalSpacarRotation().GetWithZ(angle));
        }

        static public void SetSpacarAxis(this Transform item, Axis axis, Vector3 vector)
        {
            switch (axis)
            {
                case Axis.X: item.SetSpacarRight(vector); return;
                case Axis.Y: item.SetSpacarUp(vector); return;
                case Axis.Z: item.SetSpacarForward(vector); return;
            }

            throw new UnaccountedBranchException("axis", axis);
        }
        static public void SetSpacarRight(this Transform item, Vector3 vector)
        {
            item.right = vector;
        }
        static public void SetSpacarUp(this Transform item, Vector3 vector)
        {
            item.up = vector;
        }
        static public void SetSpacarForward(this Transform item, Vector3 vector)
        {
            item.forward = vector;
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
            item.SetLocalSpacarScale(new Vector3(scale, scale, scale));
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

        static public Vector3 GetSpacarAxis(this Transform item, Axis axis)
        {
            switch (axis)
            {
                case Axis.X: return item.GetSpacarRight();
                case Axis.Y: return item.GetSpacarUp();
                case Axis.Z: return item.GetSpacarForward();
            }

            throw new UnaccountedBranchException("axis", axis);
        }
        static public Vector3 GetSpacarRight(this Transform item)
        {
            return item.right;
        }
        static public Vector3 GetSpacarUp(this Transform item)
        {
            return item.up;
        }
        static public Vector3 GetSpacarForward(this Transform item)
        {
            return item.forward;
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