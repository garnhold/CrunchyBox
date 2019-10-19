﻿using System;
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

        [SerializeField]private GameObject indicator;

        public abstract bool IsOccuringThisFrame(InputDeviceBase device);

        public string GetTitle()
        {
            return title;
        }

        public string GetCommand()
        {
            return command;
        }

        public GameObject GetIndicator()
        {
            return indicator;
        }
    }
}