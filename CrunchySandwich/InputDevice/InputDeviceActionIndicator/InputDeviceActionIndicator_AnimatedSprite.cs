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

        [SerializeField]private SortingLayerEX layer;
        [SerializeField]private int order;

        public override GameObject SpawnIndicator(InputDeviceAction action)
        {
            GameObject game_object = new GameObject();

            game_object.AddComponent<SpriteRenderer>().SetSortingLayerAndOrder(layer, order);
            game_object.AddComponent<AnimatedSpriteRenderer>().Initialize(sprite);
            return game_object;
        }
    }
}