using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class GameObjectComponentExtensions_Transform_Spacar
    {
		static public void SetSpacarPosition(this GameObject item, Vector3 position)
		{
			item.transform.SetSpacarPosition(position);
		}
		static public void SetLocalSpacarPosition(this GameObject item, Vector3 position)
		{
			item.transform.SetLocalSpacarPosition(position);
		}

		static public void SetSpacarRotation(this GameObject item, Vector3 angles)
		{
			item.transform.SetSpacarRotation(angles);
		}
		static public void SetLocalSpacarRotation(this GameObject item, Vector3 angles)
		{
			item.transform.SetLocalSpacarRotation(angles);
		}
        
        static public void SetSpacarXRotation(this GameObject item, float angle)
        {
            item.transform.SetSpacarXRotation(angle);
        }
        static public void SetLocalSpacarXRotation(this GameObject item, float angle)
        {
            item.transform.SetLocalSpacarXRotation(angle);
        }

        static public void SetSpacarYRotation(this GameObject item, float angle)
        {
            item.transform.SetSpacarYRotation(angle);
        }
        static public void SetLocalSpacarYRotation(this GameObject item, float angle)
        {
            item.transform.SetLocalSpacarYRotation(angle);
        }

        static public void SetSpacarZRotation(this GameObject item, float angle)
        {
            item.transform.SetSpacarZRotation(angle);
        }
        static public void SetLocalSpacarZRotation(this GameObject item, float angle)
        {
            item.transform.SetLocalSpacarZRotation(angle);
        }
        
        static public void SetSpacarAxis(this GameObject item, Axis axis, Vector3 vector)
        {
            item.transform.SetSpacarAxis(axis, vector);
        }
        static public void SetSpacarRight(this GameObject item, Vector3 vector)
        {
            item.transform.SetSpacarRight(vector);
        }
        static public void SetSpacarUp(this GameObject item, Vector3 vector)
        {
            item.transform.SetSpacarUp(vector);
        }
        static public void SetSpacarForward(this GameObject item, Vector3 vector)
        {
            item.transform.SetSpacarForward(vector);
        }

		static public void SetSpacarQuaternion(this GameObject item, Quaternion quaternion)
		{
			item.transform.SetSpacarQuaternion(quaternion);
		}
		static public void SetLocalSpacarQuaternion(this GameObject item, Quaternion quaternion)
		{
			item.transform.SetLocalSpacarQuaternion(quaternion);
		}

        static public void SetSpacarScale(this GameObject item, Vector3 scale)
		{
			item.transform.SetSpacarScale(scale);
		}
		static public void SetSpacarScale(this GameObject item, float scale)
		{
			item.transform.SetSpacarScale(scale);
		}
		static public void SetLocalSpacarScale(this GameObject item, Vector3 scale)
		{
			item.transform.SetLocalSpacarScale(scale);
		}
		static public void SetLocalSpacarScale(this GameObject item, float scale)
		{
			item.transform.SetLocalSpacarScale(scale);
		}

		static public Vector3 GetSpacarPosition(this GameObject item)
		{
			return item.transform.GetSpacarPosition();
		}
		static public Vector3 GetLocalSpacarPosition(this GameObject item)
		{
			return item.transform.GetLocalSpacarPosition();
		}

		static public Vector3 GetSpacarRotation(this GameObject item)
		{
			return item.transform.GetSpacarRotation();
		}
		static public Vector3 GetLocalSpacarRotation(this GameObject item)
		{
			return item.transform.GetLocalSpacarRotation();
		}
        
        static public Vector3 GetSpacarAxis(this GameObject item, Axis axis)
        {
            return item.transform.GetSpacarAxis(axis);
        }
        static public Vector3 GetSpacarRight(this GameObject item)
        {
            return item.transform.GetSpacarRight();
        }
        static public Vector3 GetSpacarUp(this GameObject item)
        {
            return item.transform.GetSpacarUp();
        }
        static public Vector3 GetSpacarForward(this GameObject item)
        {
            return item.transform.GetSpacarForward();
        }

		static public Quaternion GetSpacarQuaternion(this GameObject item)
		{
			return item.transform.GetSpacarQuaternion();
		}
		static public Quaternion GetLocalSpacarQuaternion(this GameObject item)
		{
			return item.transform.GetLocalSpacarQuaternion();
		}

        static public Vector3 GetSpacarScale(this GameObject item)
		{
			return item.transform.GetSpacarScale();
		}
		static public Vector3 GetLocalSpacarScale(this GameObject item)
		{
			return item.transform.GetLocalSpacarScale();
		}

		static public void SetSpacarPosition(this Component item, Vector3 position)
		{
			item.transform.SetSpacarPosition(position);
		}
		static public void SetLocalSpacarPosition(this Component item, Vector3 position)
		{
			item.transform.SetLocalSpacarPosition(position);
		}

		static public void SetSpacarRotation(this Component item, Vector3 angles)
		{
			item.transform.SetSpacarRotation(angles);
		}
		static public void SetLocalSpacarRotation(this Component item, Vector3 angles)
		{
			item.transform.SetLocalSpacarRotation(angles);
		}
        
        static public void SetSpacarXRotation(this Component item, float angle)
        {
            item.transform.SetSpacarXRotation(angle);
        }
        static public void SetLocalSpacarXRotation(this Component item, float angle)
        {
            item.transform.SetLocalSpacarXRotation(angle);
        }

        static public void SetSpacarYRotation(this Component item, float angle)
        {
            item.transform.SetSpacarYRotation(angle);
        }
        static public void SetLocalSpacarYRotation(this Component item, float angle)
        {
            item.transform.SetLocalSpacarYRotation(angle);
        }

        static public void SetSpacarZRotation(this Component item, float angle)
        {
            item.transform.SetSpacarZRotation(angle);
        }
        static public void SetLocalSpacarZRotation(this Component item, float angle)
        {
            item.transform.SetLocalSpacarZRotation(angle);
        }
        
        static public void SetSpacarAxis(this Component item, Axis axis, Vector3 vector)
        {
            item.transform.SetSpacarAxis(axis, vector);
        }
        static public void SetSpacarRight(this Component item, Vector3 vector)
        {
            item.transform.SetSpacarRight(vector);
        }
        static public void SetSpacarUp(this Component item, Vector3 vector)
        {
            item.transform.SetSpacarUp(vector);
        }
        static public void SetSpacarForward(this Component item, Vector3 vector)
        {
            item.transform.SetSpacarForward(vector);
        }

		static public void SetSpacarQuaternion(this Component item, Quaternion quaternion)
		{
			item.transform.SetSpacarQuaternion(quaternion);
		}
		static public void SetLocalSpacarQuaternion(this Component item, Quaternion quaternion)
		{
			item.transform.SetLocalSpacarQuaternion(quaternion);
		}

        static public void SetSpacarScale(this Component item, Vector3 scale)
		{
			item.transform.SetSpacarScale(scale);
		}
		static public void SetSpacarScale(this Component item, float scale)
		{
			item.transform.SetSpacarScale(scale);
		}
		static public void SetLocalSpacarScale(this Component item, Vector3 scale)
		{
			item.transform.SetLocalSpacarScale(scale);
		}
		static public void SetLocalSpacarScale(this Component item, float scale)
		{
			item.transform.SetLocalSpacarScale(scale);
		}

		static public Vector3 GetSpacarPosition(this Component item)
		{
			return item.transform.GetSpacarPosition();
		}
		static public Vector3 GetLocalSpacarPosition(this Component item)
		{
			return item.transform.GetLocalSpacarPosition();
		}

		static public Vector3 GetSpacarRotation(this Component item)
		{
			return item.transform.GetSpacarRotation();
		}
		static public Vector3 GetLocalSpacarRotation(this Component item)
		{
			return item.transform.GetLocalSpacarRotation();
		}
        
        static public Vector3 GetSpacarAxis(this Component item, Axis axis)
        {
            return item.transform.GetSpacarAxis(axis);
        }
        static public Vector3 GetSpacarRight(this Component item)
        {
            return item.transform.GetSpacarRight();
        }
        static public Vector3 GetSpacarUp(this Component item)
        {
            return item.transform.GetSpacarUp();
        }
        static public Vector3 GetSpacarForward(this Component item)
        {
            return item.transform.GetSpacarForward();
        }

		static public Quaternion GetSpacarQuaternion(this Component item)
		{
			return item.transform.GetSpacarQuaternion();
		}
		static public Quaternion GetLocalSpacarQuaternion(this Component item)
		{
			return item.transform.GetLocalSpacarQuaternion();
		}

        static public Vector3 GetSpacarScale(this Component item)
		{
			return item.transform.GetSpacarScale();
		}
		static public Vector3 GetLocalSpacarScale(this Component item)
		{
			return item.transform.GetLocalSpacarScale();
		}

	}
}