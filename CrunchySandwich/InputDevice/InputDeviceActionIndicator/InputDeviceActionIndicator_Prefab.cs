using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public class InputDeviceActionIndicator_Prefab : InputDeviceActionIndicator
    {
        [SerializeField]private GameObject prefab;

        public override GameObject SpawnIndicator()
        {
            return prefab.SpawnInstance();
        }
    }
}