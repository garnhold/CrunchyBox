using System;
using System.Reflection;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchySalt;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    static public class FieldInfoExtensions
    {
        static public GUIContent GetGUIContentLabel(this FieldInfo item)
        {
            return new GUIContent(item.Name.StyleEntityForDisplay());
        }
    }
}