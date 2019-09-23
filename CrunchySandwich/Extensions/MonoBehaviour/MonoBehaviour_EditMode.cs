using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyNoodle;

namespace CrunchySandwich
{
    static public class MonoBehaviourExtensions_EditMode
    {
        static public bool ShouldExecuteInEditMode(this MonoBehaviour item)
        {
            Type type = item.GetTypeEX();

            if (type.HasCustomAttributeOfType<ExecuteInEditMode>(true) || type.HasCustomAttributeOfType<ExecuteAlways>(true))
                return true;

            return false;
        }
    }
}