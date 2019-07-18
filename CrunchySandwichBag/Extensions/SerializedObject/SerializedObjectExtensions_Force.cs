using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;

namespace CrunchySandwichBag
{
    static public class SerializedObjectExtensions_Force
    {
        static public SerializedProperty ForceProperty(this SerializedObject item, string path)
        {
            return item.FindProperty(path)
                .AssertNotNull(() => new MissingFieldException("No property exists for type " + item.GetTargetType() + " and path " + path));
        }
    }
}