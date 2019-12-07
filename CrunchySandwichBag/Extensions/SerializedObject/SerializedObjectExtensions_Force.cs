using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Noodle;
    using Bun;
    
    static public class SerializedObjectExtensions_Force
    {
        static public SerializedProperty ForceProperty(this SerializedObject item, string path)
        {
            return item.FindProperty(path)
                .AssertNotNull(() => new MissingFieldException("No property exists for type " + item.GetTargetType() + " and path " + path));
        }
    }
}