﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;    
    static public class SerializedPropertyExtensions_Force
    {
        static public SerializedProperty ForceProperty(this SerializedProperty item, string path)
        {
            return item.FindPropertyRelative(path)
                .AssertNotNull(() => new MissingFieldException("No property exists for type " + item.GetVariableType() + " and path " + path));
        }
    }
}