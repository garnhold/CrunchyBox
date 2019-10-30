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
    public class EditorGUISettings : Subsystem<EditorGUISettings>
    {
        [SerializeField]private bool is_custom_gui_enabled;
        [SerializeField]private bool is_custom_scene_gui_enabled;
        [SerializeField][Range(10.0f, 300.0f)]private float default_label_width;

        [SerializeField]private bool should_auto_size_labels;
        [SerializeField][Range(0.0f, 64.0f)]private float auto_size_label_margin;

        [SerializeField]private bool should_use_visibility;
        [SerializeField]private bool should_always_show_recovery_fields;

        public bool IsCustomGUIEnabled()
        {
            return is_custom_gui_enabled;
        }

        public bool IsCustomSceneGUIEnabled()
        {
            return is_custom_scene_gui_enabled;
        }

        public float GetDefaultLabelWidth()
        {
            return default_label_width.BindBetween(10.0f, 300.0f);
        }

        public bool ShouldAutoSizeLabels()
        {
            return should_auto_size_labels;
        }

        public float GetAutoSizeLabelMargin()
        {
            return auto_size_label_margin.BindBetween(0.0f, 64.0f);
        }

        public bool ShouldUseVisibility()
        {
            return should_use_visibility;
        }

        public bool ShouldAlwaysShowRecoveryFields()
        {
            return should_always_show_recovery_fields;
        }

        public EditorGUILayoutState GetInitialLayoutState()
        {
            return new EditorGUILayoutState(
                GetDefaultLabelWidth(),
                ShouldAutoSizeLabels(),
                GetAutoSizeLabelMargin(),
                ShouldUseVisibility(),
                ShouldAlwaysShowRecoveryFields()
            );
        }
    }
}