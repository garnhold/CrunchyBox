using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class StickGestureIndicator_SpriteMap : StickGestureIndicator
    {
        [SerializeFieldEX]private GameTimer_Duration frame_timer;
        [SerializeField]private InputDeviceStickSpriteMap sprite_map;

        private int index;
        private InputDeviceStickGesture stick_gesture;

        private void Start()
        {
            frame_timer.StartExpireAndGet();
        }

        private void Update()
        {
            if (frame_timer.Repeat())
            {
                this.GetComponent<SpriteRenderer>().sprite = sprite_map.GetSprite(
                    stick_gesture.GetStickZones().GetLooped(index++)
                );
            }
        }

        public override void Initialize(InputDeviceAction_StickGesture action)
        {
            index = 0;
            stick_gesture = action.GetStickGesture();
        }
    }
}