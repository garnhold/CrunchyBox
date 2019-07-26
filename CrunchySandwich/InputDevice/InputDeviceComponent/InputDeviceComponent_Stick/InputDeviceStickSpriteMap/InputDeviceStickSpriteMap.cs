using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    [AssetClassCategory("Input")]
    public class InputDeviceStickSpriteMap : CustomAsset
    {
        [SerializeField]private Sprite center_sprite;
        [SerializeField]private Sprite right_sprite;
        [SerializeField]private Sprite right_up_sprite;
        [SerializeField]private Sprite up_sprite;
        [SerializeField]private Sprite left_up_sprite;
        [SerializeField]private Sprite left_sprite;
        [SerializeField]private Sprite left_down_sprite;
        [SerializeField]private Sprite down_sprite;
        [SerializeField]private Sprite right_down_sprite;

        public Sprite GetSprite(InputDeviceStickZone value)
        {
            switch (value)
            {
                case InputDeviceStickZone.Center: return center_sprite;
                case InputDeviceStickZone.Right: return right_sprite;
                case InputDeviceStickZone.RightUp: return right_up_sprite;
                case InputDeviceStickZone.Up: return up_sprite;
                case InputDeviceStickZone.LeftUp: return left_up_sprite;
                case InputDeviceStickZone.Left: return left_sprite;
                case InputDeviceStickZone.LeftDown: return left_down_sprite;
                case InputDeviceStickZone.Down: return down_sprite;
                case InputDeviceStickZone.RightDown: return right_down_sprite;
            }

            throw new UnaccountedBranchException("value", value);
        }
    }
}