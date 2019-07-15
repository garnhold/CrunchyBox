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

        public override GameObject SpawnIndicator()
        {
            GameObject game_object = new GameObject();

            game_object.AddComponent<SpriteRenderer>().sprite = sprite;
            return game_object;
        }
    }
}