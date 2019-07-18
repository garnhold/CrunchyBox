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
    static public partial class EditorGUIExtensions
    {
        static public T Popup<T>(Rect rect, T selected, IEnumerable<T> options)
        {
            options = options.PrepareForMultipass();

            return options.Get(
                EditorGUI.Popup(
                    rect,
                    options.FindIndexOf(selected),
                    options.Convert(o => o.IfNotNull(z => z.ToString(), "None")).ToArray()
                )
            );
        }
    }
}