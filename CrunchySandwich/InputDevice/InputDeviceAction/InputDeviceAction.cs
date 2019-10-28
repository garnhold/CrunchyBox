using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    [AssetClassCategory("Input")]
    public abstract class InputDeviceAction : CustomAsset
    {
        [SerializeField]private string title;
        [SerializeField]private string command;

        [SerializeField]private Indicator indicator;

        public abstract bool IsOccuringThisFrame(InputDeviceBase device);
        public abstract IEnumerable<InputDeviceComponentId> GetComponentIds();

        public string GetTitle()
        {
            return title;
        }

        public string GetCommand()
        {
            return command;
        }

        public Indicator GetIndicator()
        {
            return indicator;
        }
    }
}