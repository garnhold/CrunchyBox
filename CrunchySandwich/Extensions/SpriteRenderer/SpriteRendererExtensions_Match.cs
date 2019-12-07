using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class SpriteRendererExtensions_Match
    {
        static public void MatchSpriteRenderer(this SpriteRenderer item, SpriteRenderer target)
        {
            item.sprite = target.sprite;
            item.color = target.color;
            item.sharedMaterial = target.sharedMaterial;

            item.flipX = target.flipX;
            item.flipY = target.flipY;

            item.drawMode = target.drawMode;

            item.sortingLayerID = target.sortingLayerID;
            item.sortingOrder = target.sortingOrder;
        }

        static public void MatchSpriteRendererAndTransform(this SpriteRenderer item, SpriteRenderer target)
        {
            item.MatchSpriteRenderer(target);
            item.MatchPlanarTransform(target);
        }
    }
}