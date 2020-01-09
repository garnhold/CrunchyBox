using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class AnimatedSpriteRendererExtensions
    {
        static public bool Play(this AnimatedSpriteRenderer item, string name)
        {
            item.SetAnimation(name);

            return item.Play();
        }

        static public void Replay(this AnimatedSpriteRenderer item, string name)
        {
            item.SetAnimation(name);

            item.Replay();
        }

        static public bool Pause(this AnimatedSpriteRenderer item, string name)
        {
            item.SetAnimation(name);

            return item.Pause();
        }

        static public void StopClear(this AnimatedSpriteRenderer item, string name)
        {
            item.SetAnimation(name);

            item.StopClear();
        }

        static public void SetAnimatedSpriteAndTimeType(this AnimatedSpriteRenderer item, AnimatedSprite sprite, TimeType type)
        {
            item.SetAnimatedSprite(sprite);
            item.SetTimeType(type);
        }
    }
}