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
    static public class EditorSceneElementEditGadgetInstanceExtensions_Get
    {
        static public object GetContents(this EditorSceneElement_EditGadgetInstance item)
        {
            return item.GetGadgetInstance().GetContents();
        }

        static public T GetContents<T>(this EditorSceneElement_EditGadgetInstance item)
        {
            return item.GetGadgetInstance().GetContents<T>();
        }

        static public object GetAuxContents(this EditorSceneElement_EditGadgetInstance item, string name)
        {
            return item.GetGadgetInstance().GetAuxContents(name);
        }

        static public T GetAuxContents<T>(this EditorSceneElement_EditGadgetInstance item, string name)
        {
            return item.GetGadgetInstance().GetAuxContents<T>(name);
        }
    }
}