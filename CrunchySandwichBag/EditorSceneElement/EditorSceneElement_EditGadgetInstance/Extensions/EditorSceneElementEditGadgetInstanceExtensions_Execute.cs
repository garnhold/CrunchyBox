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
    static public class EditorSceneElementEditGadgetInstanceExtensions_Execute
    {
        static public void Execute(this EditorSceneElement_EditGadgetInstance item, string name)
        {
            item.GetGadgetInstance().Execute(name);
        }
    }
}