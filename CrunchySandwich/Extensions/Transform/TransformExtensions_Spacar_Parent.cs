using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class TransformExtensions_Spacar_Parent
    {
        static public Vector3 GetParentSpacarPosition(this Transform item)
        {
            return item.parent.IfNotNull(p => p.GetSpacarPosition(), Vector3.zero);
        }
        static public Vector3 GetParentLocalSpacarPosition(this Transform item)
        {
            return item.parent.IfNotNull(p => p.GetLocalSpacarPosition(), Vector3.zero);
        }

        static public Vector3 GetParentSpacarRotation(this Transform item)
        {
            return item.parent.IfNotNull(p => p.GetSpacarRotation(), Vector3.zero);
        }
        static public Vector3 GetParentLocalSpacarRotation(this Transform item)
        {
            return item.parent.IfNotNull(p => p.GetLocalSpacarRotation(), Vector3.zero);
        }

        static public Quaternion GetParentSpacarQuaternion(this Transform item)
        {
            return item.parent.IfNotNull(p => p.GetSpacarQuaternion(), Quaternion.identity);
        }
        static public Quaternion GetParentLocalSpacarQuaternion(this Transform item)
        {
            return item.parent.IfNotNull(p => p.GetLocalSpacarQuaternion(), Quaternion.identity);
        }
    }
}