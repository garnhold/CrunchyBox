using System;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyGinger;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    static public class EditorGUILayoutStateExtensions_With
    {
        static public EditorGUILayoutState GetWithCurrentLabelWidth(this EditorGUILayoutState item, float width)
        {
            return new EditorGUILayoutState(
                width,
                item.ShouldAutoSizeLabels(),
                item.GetAutoSizeLabelMargin()
            );
        }

        static public EditorGUILayoutState GetWithShouldAutoSizeLabels(this EditorGUILayoutState item, bool should)
        {
            return new EditorGUILayoutState(
                item.GetCurrentLabelWidth(),
                should,
                item.GetAutoSizeLabelMargin()
            );
        }

        static public EditorGUILayoutState GetWithAutoSizeLabelMargin(this EditorGUILayoutState item, float margin)
        {
            return new EditorGUILayoutState(
                item.GetCurrentLabelWidth(),
                item.ShouldAutoSizeLabels(),
                margin
            );
        }
    }
}