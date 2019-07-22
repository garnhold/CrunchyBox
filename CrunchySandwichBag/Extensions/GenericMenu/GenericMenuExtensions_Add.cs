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
    static public class GenericMenuExtensions_Add
    {
        static public void AddItem(this GenericMenu item, string text, Process process)
        {
            item.AddItem(new GUIContent(text), false, () => process());
        }
    }
}