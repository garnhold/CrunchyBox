using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class GameObjectComponentExtensions_Transform_Planar_Sprite
    {
		static public void SetPlanarSpriteAsLine(this GameObject item, Vector2 point1, Vector2 point2)
        {
			item.transform.SetPlanarSpriteAsLine(point1, point2);
        }

		static public void SetPlanarSpriteSize(this GameObject item, Vector2 size)
        {
            item.transform.SetPlanarSpriteSize(size);
        }
		static public void SetPlanarSpriteWidth(this GameObject item, float width)
        {
            item.transform.SetPlanarSpriteWidth(width);
        }
        static public void SetPlanarSpriteHeight(this GameObject item, float height)
        {
            item.transform.SetPlanarSpriteHeight(height);
        }
        
		static public Vector2 GetPlanarSpriteSize(this GameObject item)
		{
			return item.transform.GetPlanarSpriteSize();
		}

		static public void SetPlanarSpriteAsLine(this Component item, Vector2 point1, Vector2 point2)
        {
			item.transform.SetPlanarSpriteAsLine(point1, point2);
        }

		static public void SetPlanarSpriteSize(this Component item, Vector2 size)
        {
            item.transform.SetPlanarSpriteSize(size);
        }
		static public void SetPlanarSpriteWidth(this Component item, float width)
        {
            item.transform.SetPlanarSpriteWidth(width);
        }
        static public void SetPlanarSpriteHeight(this Component item, float height)
        {
            item.transform.SetPlanarSpriteHeight(height);
        }
        
		static public Vector2 GetPlanarSpriteSize(this Component item)
		{
			return item.transform.GetPlanarSpriteSize();
		}

	}
}