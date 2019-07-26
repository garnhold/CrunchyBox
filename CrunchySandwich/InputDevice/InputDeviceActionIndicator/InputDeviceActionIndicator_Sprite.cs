using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public class InputDeviceActionIndicator_Sprite : InputDeviceActionIndicator
    {
        [SerializeField]private Sprite sprite;

        [SerializeField]private SortingLayerEX layer;
        [SerializeField]private int order;

        public override GameObject SpawnIndicator(InputDeviceAction action)
        {
            GameObject game_object = new GameObject();
            SpriteRenderer renderer = game_object.AddComponent<SpriteRenderer>();

            renderer.sprite = sprite;
            renderer.SetSortingLayerAndOrder(layer, order);
            return game_object;
        }
    }
}