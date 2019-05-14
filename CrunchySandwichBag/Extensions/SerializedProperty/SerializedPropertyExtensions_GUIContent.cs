using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyBun;

namespace CrunchySandwichBag
{
    static public class SerializedPropertyExtensions_GUIContent
    {
        static public GUIContent GetGUIContentLabel(this SerializedProperty item)
        {
            return new GUIContent(item.name.StyleEntityForDisplay());
        }
    }
}