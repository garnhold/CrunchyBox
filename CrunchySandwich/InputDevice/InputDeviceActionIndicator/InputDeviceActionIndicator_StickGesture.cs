using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public class InputDeviceActionIndicator_StickGesture : InputDeviceActionIndicator<InputDeviceAction_StickGesture>
    {
        [SerializeField][PrefabField(true)]private StickGestureIndicator prefab;

        protected override GameObject SpawnIndicatorInternal(InputDeviceAction_StickGesture action)
        {
            StickGestureIndicator instance = prefab.SpawnInstance();

            instance.Initialize(action);
            return instance.gameObject;
        }
    }
}