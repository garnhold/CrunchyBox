using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class BoxCollider2DExtensions
    {
        static public void SetLocalRect(this BoxCollider2D item, Rect rect)
        {
            item.offset = rect.center;
            item.size = rect.size;
        }
        static public void SetWorldRect(this BoxCollider2D item, Rect rect)
        {
            item.offset = item.transform.InverseTransformPoint(rect.center);
            item.size = item.transform.InverseTransformVector(rect.size);
        }

        static public Rect GetLocalRect(this BoxCollider2D item)
        {
            return RectExtensions.CreateCenterRect(item.offset, item.size);
        }
        static public Rect GetWorldRect(this BoxCollider2D item)
        {
            return RectExtensions.CreateCenterRect(
                item.transform.TransformPoint(item.offset),
                item.transform.TransformVector(item.size)
            );
        }
    }
}