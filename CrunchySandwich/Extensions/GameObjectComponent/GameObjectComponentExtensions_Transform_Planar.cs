using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class GameObjectComponentExtensions_Transform_Planar
    {
		static public void SetPlanarPosition(this GameObject item, Vector2 position)
        {
            item.transform.SetPlanarPosition(position);
        }
        static public void SetLocalPlanarPosition(this GameObject item, Vector2 position)
        {
            item.transform.SetLocalPlanarPosition(position);
        }
		static public void SetOffsetPlanarPosition(this GameObject item, Vector2 position)
		{
			item.transform.SetOffsetPlanarPosition(position);
		}
        
        static public void SetPlanarZPosition(this GameObject item, float position)
        {
            item.transform.SetPlanarZPosition(position);
        }
        static public void SetLocalPlanarZPosition(this GameObject item, float position)
        {
            item.transform.SetLocalPlanarZPosition(position);
        }

        static public void SetPlanarRotation(this GameObject item, float angle)
        {
            item.transform.SetPlanarRotation(angle);
        }
        static public void SetLocalPlanarRotation(this GameObject item, float angle)
        {
            item.transform.SetLocalPlanarRotation(angle);
        }

        static public void SetPlanarScale(this GameObject item, Vector2 scale)
        {
            item.transform.SetPlanarScale(scale);
        }
        static public void SetPlanarScale(this GameObject item, float scale)
        {
            item.transform.SetPlanarScale(scale);
        }
        static public void SetLocalPlanarScale(this GameObject item, Vector2 scale)
        {
            item.transform.SetLocalPlanarScale(scale);
        }
        static public void SetLocalPlanarScale(this GameObject item, float scale)
        {
            item.transform.SetLocalPlanarScale(scale);
        }

        static public Vector2 GetPlanarPosition(this GameObject item)
        {
            return item.transform.GetPlanarPosition();
        }
        static public Vector2 GetLocalPlanarPosition(this GameObject item)
        {
            return item.transform.GetLocalPlanarPosition();
        }
		static public Vector2 GetOffsetPlanarPosition(this GameObject item)
		{
			return item.transform.GetOffsetPlanarPosition();
		}

        static public float GetPlanarRotation(this GameObject item)
        {
            return item.transform.GetPlanarRotation();
        }
        static public float GetLocalPlanarRotation(this GameObject item)
        {
            return item.transform.GetLocalPlanarRotation();
        }

        static public Vector2 GetPlanarScale(this GameObject item)
        {
            return item.transform.GetPlanarScale();
        }
        static public Vector2 GetLocalPlanarScale(this GameObject item)
        {
            return item.transform.GetLocalPlanarScale();
        }

		static public void SetPlanarPosition(this Component item, Vector2 position)
        {
            item.transform.SetPlanarPosition(position);
        }
        static public void SetLocalPlanarPosition(this Component item, Vector2 position)
        {
            item.transform.SetLocalPlanarPosition(position);
        }
		static public void SetOffsetPlanarPosition(this Component item, Vector2 position)
		{
			item.transform.SetOffsetPlanarPosition(position);
		}
        
        static public void SetPlanarZPosition(this Component item, float position)
        {
            item.transform.SetPlanarZPosition(position);
        }
        static public void SetLocalPlanarZPosition(this Component item, float position)
        {
            item.transform.SetLocalPlanarZPosition(position);
        }

        static public void SetPlanarRotation(this Component item, float angle)
        {
            item.transform.SetPlanarRotation(angle);
        }
        static public void SetLocalPlanarRotation(this Component item, float angle)
        {
            item.transform.SetLocalPlanarRotation(angle);
        }

        static public void SetPlanarScale(this Component item, Vector2 scale)
        {
            item.transform.SetPlanarScale(scale);
        }
        static public void SetPlanarScale(this Component item, float scale)
        {
            item.transform.SetPlanarScale(scale);
        }
        static public void SetLocalPlanarScale(this Component item, Vector2 scale)
        {
            item.transform.SetLocalPlanarScale(scale);
        }
        static public void SetLocalPlanarScale(this Component item, float scale)
        {
            item.transform.SetLocalPlanarScale(scale);
        }

        static public Vector2 GetPlanarPosition(this Component item)
        {
            return item.transform.GetPlanarPosition();
        }
        static public Vector2 GetLocalPlanarPosition(this Component item)
        {
            return item.transform.GetLocalPlanarPosition();
        }
		static public Vector2 GetOffsetPlanarPosition(this Component item)
		{
			return item.transform.GetOffsetPlanarPosition();
		}

        static public float GetPlanarRotation(this Component item)
        {
            return item.transform.GetPlanarRotation();
        }
        static public float GetLocalPlanarRotation(this Component item)
        {
            return item.transform.GetLocalPlanarRotation();
        }

        static public Vector2 GetPlanarScale(this Component item)
        {
            return item.transform.GetPlanarScale();
        }
        static public Vector2 GetLocalPlanarScale(this Component item)
        {
            return item.transform.GetLocalPlanarScale();
        }

	}
}