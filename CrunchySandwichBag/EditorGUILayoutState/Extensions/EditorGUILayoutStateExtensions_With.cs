using System;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Salt;
    using Noodle;
    using Ginger;
    using Sandwich;
    
    static public class EditorGUILayoutStateExtensions_With
    {
        static public EditorGUILayoutState GetWithCurrentLabelWidth(this EditorGUILayoutState item, float width)
        {
            return new EditorGUILayoutState(
                width,
                item.ShouldAutoSizeLabels(),
                item.GetAutoSizeLabelMargin(),
                item.ShouldUseVisibility(),
                item.ShouldAlwaysShowRecoveryFields()
            );
        }

        static public EditorGUILayoutState GetWithShouldAutoSizeLabels(this EditorGUILayoutState item, bool should)
        {
            return new EditorGUILayoutState(
                item.GetCurrentLabelWidth(),
                should,
                item.GetAutoSizeLabelMargin(),
                item.ShouldUseVisibility(),
                item.ShouldAlwaysShowRecoveryFields()
            );
        }

        static public EditorGUILayoutState GetWithAutoSizeLabelMargin(this EditorGUILayoutState item, float margin)
        {
            return new EditorGUILayoutState(
                item.GetCurrentLabelWidth(),
                item.ShouldAutoSizeLabels(),
                margin,
                item.ShouldUseVisibility(),
                item.ShouldAlwaysShowRecoveryFields()
            );
        }

        static public EditorGUILayoutState GetWithShouldUseVisibility(this EditorGUILayoutState item, bool should)
        {
            return new EditorGUILayoutState(
                item.GetCurrentLabelWidth(),
                item.ShouldAutoSizeLabels(),
                item.GetAutoSizeLabelMargin(),
                should,
                item.ShouldAlwaysShowRecoveryFields()
            );
        }

        static public EditorGUILayoutState GetWithShouldAlwaysShowRecoveryFields(this EditorGUILayoutState item, bool should)
        {
            return new EditorGUILayoutState(
                item.GetCurrentLabelWidth(),
                item.ShouldAutoSizeLabels(),
                item.GetAutoSizeLabelMargin(),
                item.ShouldUseVisibility(),
                should
            );
        }
    }
}