using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class SpriteRendererExtensions_Points
    {
        static public Vector2 GetLocalCenter(this SpriteRenderer item)
        {
            return item.sprite.GetWorldCenter();
        }
        static public Vector2 GetWorldCenter(this SpriteRenderer item)
        {
            return item.transform.TransformPoint(item.GetLocalCenter());
        }

        static public Vector2 GetLocalBottomCenter(this SpriteRenderer item)
        {
            return item.sprite.GetWorldBottomCenter();
        }
        static public Vector3 GetWorldBottomCenter(this SpriteRenderer item)
        {
            return item.transform.TransformPoint(item.GetLocalBottomCenter());
        }

        static public Vector2 GetLocalTopCenter(this SpriteRenderer item)
        {
            return item.sprite.GetWorldTopCenter();
        }
        static public Vector3 GetWorldTopCenter(this SpriteRenderer item)
        {
            return item.transform.TransformPoint(item.GetLocalTopCenter());
        }

        static public Vector2 GetLocalLeftCenter(this SpriteRenderer item)
        {
            return item.sprite.GetWorldLeftCenter();
        }
        static public Vector3 GetWorldLeftCenter(this SpriteRenderer item)
        {
            return item.transform.TransformPoint(item.GetLocalLeftCenter());
        }

        static public Vector2 GetLocalRightCenter(this SpriteRenderer item)
        {
            return item.sprite.GetWorldRightCenter();
        }
        static public Vector3 GetWorldRightCenter(this SpriteRenderer item)
        {
            return item.transform.TransformPoint(item.GetLocalRightCenter());
        }

        static public Vector2 GetLocalBottomLeft(this SpriteRenderer item)
        {
            return item.sprite.GetWorldBottomLeft();
        }
        static public Vector3 GetWorldBottomLeft(this SpriteRenderer item)
        {
            return item.transform.TransformPoint(item.GetLocalBottomLeft());
        }

        static public Vector2 GetLocalBottomRight(this SpriteRenderer item)
        {
            return item.sprite.GetWorldBottomRight();
        }
        static public Vector3 GetWorldBottomRight(this SpriteRenderer item)
        {
            return item.transform.TransformPoint(item.GetLocalBottomRight());
        }

        static public Vector2 GetLocalTopLeft(this SpriteRenderer item)
        {
            return item.sprite.GetWorldTopLeft();
        }
        static public Vector3 GetWorldTopLeft(this SpriteRenderer item)
        {
            return item.transform.TransformPoint(item.GetLocalTopLeft());
        }

        static public Vector2 GetLocalTopRight(this SpriteRenderer item)
        {
            return item.sprite.GetWorldTopRight();
        }
        static public Vector3 GetWorldTopRight(this SpriteRenderer item)
        {
            return item.transform.TransformPoint(item.GetLocalTopRight());
        }
    }
}