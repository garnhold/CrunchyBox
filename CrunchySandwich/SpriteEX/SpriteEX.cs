using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    [AssetClassCategory("Sprite")]
    public class SpriteEX : CustomAsset
    {
        [SerializeField]private Sprite sprite;
        [SerializeField]private List<SpritePoint> points;

        public Sprite GetSprite()
        {
            return sprite;
        }

        public IEnumerable<Vector2> GetPoints(string label)
        {
            return points.Narrow(p => p.GetLabel() == label)
                .Convert(p => p.GetPoint());
        }

        public IEnumerable<Vector2> GetWorldPoints(string label)
        {
            return GetPoints(label).Convert(p => (p - sprite.pivot) * sprite.GetUnitsPerPixel());
        }
    }
}