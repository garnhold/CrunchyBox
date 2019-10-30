using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using UnityEngine.Internal;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    static public class EditorGUIElementExtensions_Convenience
    {
        static public EditorGUIElement InitilizeAndGet(this EditorGUIElement item)
        {
            item.Initialize();

            return item;
        }
    }
}