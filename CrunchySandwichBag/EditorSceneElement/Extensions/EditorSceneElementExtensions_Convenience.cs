using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    static public class EditorSceneElementExtensions_Convenience
    {
        static public EditorSceneElement InitilizeAndGet(this EditorSceneElement item)
        {
            item.Initilize();

            return item;
        }
    }
}