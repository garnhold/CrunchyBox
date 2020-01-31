using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class GameObjectComponentExtensions_Transform_Arear
    {
		static public void SetArearPosition(this GameObject item, Vector2 position)
        {
            item.transform.SetArearPosition(position);
        }
        static public void SetLocalArearPosition(this GameObject item, Vector2 position)
        {
            item.transform.SetLocalArearPosition(position);
        }
		static public void SetOffsetArearPosition(this GameObject item, Vector2 position)
		{
			item.transform.SetOffsetArearPosition(position);
		}

        static public void SetArearRotation(this GameObject item, float angle)
        {
            item.transform.SetArearRotation(angle);
        }
        static public void SetLocalArearRotation(this GameObject item, float angle)
        {
            item.transform.SetLocalArearRotation(angle);
        }

        static public void SetArearScale(this GameObject item, Vector2 scale)
        {
            item.transform.SetArearScale(scale);
        }
        static public void SetArearScale(this GameObject item, float scale)
        {
            item.transform.SetArearScale(scale);
        }
        static public void SetLocalArearScale(this GameObject item, Vector2 scale)
        {
            item.transform.SetLocalArearScale(scale);
        }
        static public void SetLocalArearScale(this GameObject item, float scale)
        {
            item.transform.SetLocalArearScale(scale);
        }

        static public Vector2 GetArearPosition(this GameObject item)
        {
            return item.transform.GetArearPosition();
        }
        static public Vector2 GetLocalArearPosition(this GameObject item)
        {
            return item.transform.GetLocalArearPosition();
        }
		static public Vector2 GetOffsetArearPosition(this GameObject item)
		{
			return item.transform.GetOffsetArearPosition();
		}

        static public float GetArearRotation(this GameObject item)
        {
            return item.transform.GetArearRotation();
        }
        static public float GetLocalArearRotation(this GameObject item)
        {
            return item.transform.GetLocalArearRotation();
        }

        static public Vector2 GetArearScale(this GameObject item)
        {
            return item.transform.GetArearScale();
        }
        static public Vector2 GetLocalArearScale(this GameObject item)
        {
            return item.transform.GetLocalArearScale();
        }

		static public void SetArearPosition(this Component item, Vector2 position)
        {
            item.transform.SetArearPosition(position);
        }
        static public void SetLocalArearPosition(this Component item, Vector2 position)
        {
            item.transform.SetLocalArearPosition(position);
        }
		static public void SetOffsetArearPosition(this Component item, Vector2 position)
		{
			item.transform.SetOffsetArearPosition(position);
		}

        static public void SetArearRotation(this Component item, float angle)
        {
            item.transform.SetArearRotation(angle);
        }
        static public void SetLocalArearRotation(this Component item, float angle)
        {
            item.transform.SetLocalArearRotation(angle);
        }

        static public void SetArearScale(this Component item, Vector2 scale)
        {
            item.transform.SetArearScale(scale);
        }
        static public void SetArearScale(this Component item, float scale)
        {
            item.transform.SetArearScale(scale);
        }
        static public void SetLocalArearScale(this Component item, Vector2 scale)
        {
            item.transform.SetLocalArearScale(scale);
        }
        static public void SetLocalArearScale(this Component item, float scale)
        {
            item.transform.SetLocalArearScale(scale);
        }

        static public Vector2 GetArearPosition(this Component item)
        {
            return item.transform.GetArearPosition();
        }
        static public Vector2 GetLocalArearPosition(this Component item)
        {
            return item.transform.GetLocalArearPosition();
        }
		static public Vector2 GetOffsetArearPosition(this Component item)
		{
			return item.transform.GetOffsetArearPosition();
		}

        static public float GetArearRotation(this Component item)
        {
            return item.transform.GetArearRotation();
        }
        static public float GetLocalArearRotation(this Component item)
        {
            return item.transform.GetLocalArearRotation();
        }

        static public Vector2 GetArearScale(this Component item)
        {
            return item.transform.GetArearScale();
        }
        static public Vector2 GetLocalArearScale(this Component item)
        {
            return item.transform.GetLocalArearScale();
        }

	}
}