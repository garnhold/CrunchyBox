using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyGinger;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public class InputDeviceActionsSettings : LibrarySettings
    {
        public override string GetLibraryName()
        {
            return "InputDeviceActions";
        }

        public override IEnumerable<UnityEngine.Object> GetObjects()
        {
            return Project.GetAllSofabs<InputDeviceAction>()
                .Convert<InputDeviceAction, UnityEngine.Object>();
        }
    }
}