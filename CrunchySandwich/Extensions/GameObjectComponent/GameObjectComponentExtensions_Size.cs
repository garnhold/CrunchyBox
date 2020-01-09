using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class GameObjectComponentExtensions_Size
    {

		static public Vector2 GetPlanarSize(this GameObject item)
        {
            SpriteRenderer sprite_renderer = item.GetComponent<SpriteRenderer>();
            if (sprite_renderer.IsNotNull())
                return sprite_renderer.GetSize();

            RectTransform rect_transform = item.GetComponent<RectTransform>();
            if (rect_transform.IsNotNull())
                return rect_transform.GetSize();

            Collider2D collider2d = item.GetComponent<Collider2D>();
            if (collider2d.IsNotNull())
                return collider2d.GetSize();

            Camera camera = item.GetComponent<Camera>();
            if (camera.IsNotNull())
                return camera.GetOrthographicSize();

            return item.GetParentPlanarSize();
        }

        static public Vector2 GetParentPlanarSize(this GameObject item)
        {
            GameObject parent = item.GetParent();
            if (parent.IsNotNull())
                return parent.GetPlanarSize();

            return Camera.main.GetOrthographicSize();
        }

		static public Vector2 GetPlanarSize(this Component item)
        {
            SpriteRenderer sprite_renderer = item.GetComponent<SpriteRenderer>();
            if (sprite_renderer.IsNotNull())
                return sprite_renderer.GetSize();

            RectTransform rect_transform = item.GetComponent<RectTransform>();
            if (rect_transform.IsNotNull())
                return rect_transform.GetSize();

            Collider2D collider2d = item.GetComponent<Collider2D>();
            if (collider2d.IsNotNull())
                return collider2d.GetSize();

            Camera camera = item.GetComponent<Camera>();
            if (camera.IsNotNull())
                return camera.GetOrthographicSize();

            return item.GetParentPlanarSize();
        }

        static public Vector2 GetParentPlanarSize(this Component item)
        {
            GameObject parent = item.GetParent();
            if (parent.IsNotNull())
                return parent.GetPlanarSize();

            return Camera.main.GetOrthographicSize();
        }
	}
}