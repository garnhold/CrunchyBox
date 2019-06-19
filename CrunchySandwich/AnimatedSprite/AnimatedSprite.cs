using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    [CustomAssetCategory("AnimatedSprite")]
    public class AnimatedSprite : CustomAsset
    {
        [SerializeField]private SpriteAnimation[] animations;

        public void Initialize(IEnumerable<SpriteAnimation> a)
        {
            animations = a.ToArray();
        }

        public Sprite GetDefaultFrame()
        {
            return GetDefaultAnimation().GetDefaultFrame();
        }

        public SpriteAnimation GetDefaultAnimation()
        {
            return animations.GetFirst();
        }

        public SpriteAnimation GetAnimation(string name)
        {
            return animations.FindFirst(a => a.GetName() == name) ?? GetDefaultAnimation();
        }
    }
}