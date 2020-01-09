using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Salt;
    using Noodle;
    using Ginger;
    using Sandwich;
    
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