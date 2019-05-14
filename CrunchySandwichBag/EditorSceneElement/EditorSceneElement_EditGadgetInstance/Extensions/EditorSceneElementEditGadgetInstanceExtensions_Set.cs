using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchySauce;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    static public class EditorSceneElementEditGadgetInstanceExtensions_Set
    {
        static public void SetContents(this EditorSceneElement_EditGadgetInstance item, object value)
        {
            item.GetGadgetInstance().SetContents(value);
        }

        static public void SetAuxContents(this EditorSceneElement_EditGadgetInstance item, string name, object value)
        {
            item.GetGadgetInstance().SetAuxContents(name, value);
        }
    }
}