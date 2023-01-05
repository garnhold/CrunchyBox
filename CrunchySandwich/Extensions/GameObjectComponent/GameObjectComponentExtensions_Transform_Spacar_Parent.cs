using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class GameObjectComponentExtensions_Transform_Spacar_Parent
    {
		static public Vector3 GetParentSpacarPosition(this GameObject item)
        {
            return item.transform.GetParentSpacarPosition();
        }
        static public Vector3 GetParentLocalSpacarPosition(this GameObject item)
        {
            return item.transform.GetParentLocalSpacarPosition();
        }
        
        static public Vector3 GetParentSpacarRotation(this GameObject item)
        {
            return item.transform.GetParentSpacarRotation();
        }
        static public Vector3 GetParentLocalSpacarRotation(this GameObject item)
        {
            return item.transform.GetParentLocalSpacarRotation();
        }

        static public Quaternion GetParentSpacarQuaternion(this GameObject item)
        {
            return item.transform.GetParentSpacarQuaternion();
        }
        static public Quaternion GetParentLocalSpacarQuaternion(this GameObject item)
        {
            return item.transform.GetParentLocalSpacarQuaternion();
        }
		static public Vector3 GetParentSpacarPosition(this Component item)
        {
            return item.transform.GetParentSpacarPosition();
        }
        static public Vector3 GetParentLocalSpacarPosition(this Component item)
        {
            return item.transform.GetParentLocalSpacarPosition();
        }
        
        static public Vector3 GetParentSpacarRotation(this Component item)
        {
            return item.transform.GetParentSpacarRotation();
        }
        static public Vector3 GetParentLocalSpacarRotation(this Component item)
        {
            return item.transform.GetParentLocalSpacarRotation();
        }

        static public Quaternion GetParentSpacarQuaternion(this Component item)
        {
            return item.transform.GetParentSpacarQuaternion();
        }
        static public Quaternion GetParentLocalSpacarQuaternion(this Component item)
        {
            return item.transform.GetParentLocalSpacarQuaternion();
        }
	}
}