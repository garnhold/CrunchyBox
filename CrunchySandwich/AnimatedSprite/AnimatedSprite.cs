using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    [AssetClassCategory("Sprite")]
    public class AnimatedSprite : CustomAsset
    {
        [SerializeField]private SpriteAnimation[] animations;

        public void Initialize(IEnumerable<SpriteAnimation> a)
        {
            animations = a.ToArray();
        }
        public void Initialize(params SpriteAnimation[] a)
        {
            Initialize((IEnumerable<SpriteAnimation>)a);
        }

        public Sprite GetDefaultFrame()
        {
            return GetDefaultAnimation().GetFirstFrame();
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