using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    [CustomAssetCategory("Sprite")]
    public class SpriteSheet : CustomAsset
    {
        [SerializeField]private SpriteAnimation[] animations;

        public void Initialize(IEnumerable<SpriteAnimation> a)
        {
            animations = a.ToArray();
        }

        public SpriteAnimation GetAnimation(string name)
        {
            return animations.FindFirst(a => a.GetName() == name);
        }
    }
}