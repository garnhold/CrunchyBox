using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public class InputDeviceActionIndicator_AnimatedSprite : InputDeviceActionIndicator
    {
        [SerializeField]private AnimatedSprite sprite;

        public override GameObject SpawnIndicator()
        {
            GameObject game_object = new GameObject();

            game_object.AddComponent<SpriteRenderer>();
            game_object.AddComponent<AnimatedSpriteRenderer>().Initialize(sprite);
            return game_object;
        }
    }
}