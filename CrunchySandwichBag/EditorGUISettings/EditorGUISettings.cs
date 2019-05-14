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
    public class EditorGUISettings : Subsystem
    {
        [SerializeField]private bool is_custom_gui_enabled;
        [SerializeField]private bool is_custom_scene_gui_enabled;
        [SerializeField][Range(10.0f, 300.0f)]private float default_label_width;

        static public EditorGUISettings GetInstance()
        {
            return Subsystem.GetInstance<EditorGUISettings>();
        }

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
    }
}