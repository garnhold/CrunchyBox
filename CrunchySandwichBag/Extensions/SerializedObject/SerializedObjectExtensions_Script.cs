using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;    
    static public class SerializedObjectExtensions_Script
    {
        static public bool HasScript(this SerializedObject item)
        {
            if (item.GetScript() != null)
                return true;

            return false;
        }

        static public bool IsMissingScript(this SerializedObject item)
        {
            if (item.HasScript() == false)
                return true;

            return false;
        }

        static public MonoScript GetScript(this SerializedObject item)
        {
            return item.GetChildValue<MonoScript>("m_Script");
        }
    }
}