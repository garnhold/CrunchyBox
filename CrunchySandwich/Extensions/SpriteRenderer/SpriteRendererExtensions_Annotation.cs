using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class SpriteRendererExtensions_Annotation
    {
        static public Vector2 GetLabeledLocalPoint(this SpriteRenderer item, string label)
        {
            return item.sprite.IfNotNull(s => s.GetLabeledLocalPoint(label));
        }

        static public Vector2 GetLabeledWorldPoint(this SpriteRenderer item, string label)
        {
            return item.transform.TransformPoint(item.GetLabeledLocalPoint(label));
        }
    }
}