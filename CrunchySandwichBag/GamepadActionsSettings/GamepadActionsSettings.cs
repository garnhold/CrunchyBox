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
    
    public class GamepadActionsSettings : LibrarySettings
    {
        public override string GetLibraryName()
        {
            return "GamepadActions";
        }

        public override IEnumerable<UnityEngine.Object> GetObjects()
        {
            return Project.GetAllSofabs<GamepadAction>()
                .Convert<GamepadAction, UnityEngine.Object>();
        }
    }
}