using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Salt;
    using Noodle;    
    static public class SerializedPropertyExtensions_GUIContent
    {
        static public GUIContent GetGUIContentLabel(this SerializedProperty item)
        {
            return new GUIContent(item.name.StyleEntityForDisplay());
        }
    }
}