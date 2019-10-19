using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyGinger;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    static public class PrefabExtensions_Prefabs
    {
        static public void PushPrefabToPrefabs(this Prefab item, SerializedObject obj)
        {
            obj.SetChildValue(item.GetPrefabsName().StyleAsUnderscoredEntity(), item);
        }

        static public string GetPrefabsName(this Prefab item)
        {
            return item.name.StyleAsVariableName();
        }
    }
}