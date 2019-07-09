﻿using System;
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
    public class EditorGUILayoutState
    {
        private float current_label_width;

        private bool should_auto_size_labels;
        private float auto_size_label_margin;

        static public bool operator ==(EditorGUILayoutState s1, EditorGUILayoutState s2)
        {
            if (s1.current_label_width == s2.current_label_width)
            {
                if (s1.should_auto_size_labels == s2.should_auto_size_labels)
                {
                    if (s1.auto_size_label_margin == s2.auto_size_label_margin)
                        return true;
                }
            }

            return false;
        }
        static public bool operator !=(EditorGUILayoutState s1, EditorGUILayoutState s2)
        {
            if (s1 == s2)
                return false;

            return true;
        }

        public EditorGUILayoutState(float w, bool a, float m)
        {
            current_label_width = w;

            should_auto_size_labels = a;
            auto_size_label_margin = m;
        }

        public EditorGUILayoutState(float w) : this(w, false, 10.0f) { }
        public EditorGUILayoutState() : this(10.0f) { }

        public float GetCurrentLabelWidth()
        {
            return current_label_width;
        }

        public bool ShouldAutoSizeLabels()
        {
            return should_auto_size_labels;
        }

        public float GetAutoSizeLabelMargin()
        {
            return auto_size_label_margin;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;

                hash = hash * 23 + current_label_width.GetHashCode();
                hash = hash * 23 + should_auto_size_labels.GetHashCode();
                hash = hash * 23 + auto_size_label_margin.GetHashCode();
                return hash;
            }
        }

        public override bool Equals(object obj)
        {
            EditorGUILayoutState cast;

            if (obj.Convert<EditorGUILayoutState>(out cast))
            {
                if (cast == this)
                    return true;
            }

            return false;
        }
    }
}