using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public abstract class InputDeviceAction<ALL, AXIS, BUTTON, STICK> : InputDeviceAction
    {
        public abstract bool IsOccuringThisFrame(InputDevice<ALL, AXIS, BUTTON, STICK> device);
    }

    [AssetClassCategory("Input")]
    public abstract class InputDeviceAction : CustomAsset
    {
        [SerializeField]private string title;
        [SerializeField]private string command;

        [SerializeFieldEX][PolymorphicField]private InputDeviceActionIndicator indicator;

        public string GetTitle()
        {
            return title;
        }

        public string GetCommand()
        {
            return command;
        }

        public GameObject SpawnIndicator()
        {
            return indicator.SpawnIndicator();
        }
    }
}