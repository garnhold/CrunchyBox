using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class GameObjectComponentExtensions_Transform_Spacar_MoveInterpolate
    {
		static public bool MoveInterpolateSpacarPosition(this GameObject item, Vector3 target, float amount)
        {
            return item.transform.MoveInterpolateSpacarPosition(target, amount);
        }
        static public bool MoveInterpolateLocalSpacarPosition(this GameObject item, Vector3 target, float amount)
        {
            return item.transform.MoveInterpolateLocalSpacarPosition(target, amount);
        }
        
        static public bool MoveInterpolateSpacarForward(this GameObject item, Vector3 target, float amount)
        {
            return item.transform.MoveInterpolateSpacarForward(target, amount);
        }
        static public bool MoveInterpolateSpacarUp(this GameObject item, Vector3 target, float amount)
        {
            return item.transform.MoveInterpolateSpacarUp(target, amount);
        }
        
        static public bool MoveInterpolateSpacarQuaternion(this GameObject item, Quaternion target, float amount)
        {
            return item.transform.MoveInterpolateSpacarQuaternion(target, amount);
        }
        static public bool MoveInterpolateLocalSpacarQuaternion(this GameObject item, Quaternion target, float amount)
        {
            return item.transform.MoveInterpolateLocalSpacarQuaternion(target, amount);
        }

        static public bool MoveInterpolateSpacarScale(this GameObject item, Vector3 target, float amount)
        {
            return item.transform.MoveInterpolateSpacarScale(target, amount);
        }
        static public bool MoveInterpolateLocalSpacarScale(this GameObject item, Vector3 target, float amount)
        {
            return item.transform.MoveInterpolateLocalSpacarScale(target, amount);
        }

		static public bool MoveInterpolateSpacarScale(this GameObject item, float target, float amount)
        {
            return item.transform.MoveInterpolateSpacarScale(target, amount);
        }
        static public bool MoveInterpolateLocalSpacarScale(this GameObject item, float target, float amount)
        {
            return item.transform.MoveInterpolateLocalSpacarScale(target, amount);
        }

		static public bool MoveInterpolateSpacarPosition(this Component item, Vector3 target, float amount)
        {
            return item.transform.MoveInterpolateSpacarPosition(target, amount);
        }
        static public bool MoveInterpolateLocalSpacarPosition(this Component item, Vector3 target, float amount)
        {
            return item.transform.MoveInterpolateLocalSpacarPosition(target, amount);
        }
        
        static public bool MoveInterpolateSpacarForward(this Component item, Vector3 target, float amount)
        {
            return item.transform.MoveInterpolateSpacarForward(target, amount);
        }
        static public bool MoveInterpolateSpacarUp(this Component item, Vector3 target, float amount)
        {
            return item.transform.MoveInterpolateSpacarUp(target, amount);
        }
        
        static public bool MoveInterpolateSpacarQuaternion(this Component item, Quaternion target, float amount)
        {
            return item.transform.MoveInterpolateSpacarQuaternion(target, amount);
        }
        static public bool MoveInterpolateLocalSpacarQuaternion(this Component item, Quaternion target, float amount)
        {
            return item.transform.MoveInterpolateLocalSpacarQuaternion(target, amount);
        }

        static public bool MoveInterpolateSpacarScale(this Component item, Vector3 target, float amount)
        {
            return item.transform.MoveInterpolateSpacarScale(target, amount);
        }
        static public bool MoveInterpolateLocalSpacarScale(this Component item, Vector3 target, float amount)
        {
            return item.transform.MoveInterpolateLocalSpacarScale(target, amount);
        }

		static public bool MoveInterpolateSpacarScale(this Component item, float target, float amount)
        {
            return item.transform.MoveInterpolateSpacarScale(target, amount);
        }
        static public bool MoveInterpolateLocalSpacarScale(this Component item, float target, float amount)
        {
            return item.transform.MoveInterpolateLocalSpacarScale(target, amount);
        }

	}
}