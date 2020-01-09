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
    
    public class EditorGUILayoutState
    {
        private float current_label_width;

        private bool should_auto_size_labels;
        private float auto_size_label_margin;

        private bool should_use_visibility;
        private bool should_always_show_recovery_fields;

        static public bool operator ==(EditorGUILayoutState s1, EditorGUILayoutState s2)
        {
            if (s1.current_label_width == s2.current_label_width &&
                s1.should_auto_size_labels == s2.should_auto_size_labels &&
                s1.auto_size_label_margin == s2.auto_size_label_margin &&
                s1.should_use_visibility == s2.should_use_visibility &&
                s1.should_always_show_recovery_fields == s2.should_always_show_recovery_fields
                )
            {
                return true;
            }

            return false;
        }
        static public bool operator !=(EditorGUILayoutState s1, EditorGUILayoutState s2)
        {
            if (s1 == s2)
                return false;

            return true;
        }

        public EditorGUILayoutState(float w, bool a, float m, bool v, bool c)
        {
            current_label_width = w;

            should_auto_size_labels = a;
            auto_size_label_margin = m;

            should_use_visibility = v;
            should_always_show_recovery_fields = c;
        }

        public EditorGUILayoutState() : this(10.0f, false, 10.0f, false, false) { }

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

        public bool ShouldUseVisibility()
        {
            return should_use_visibility;
        }

        public bool ShouldAlwaysShowRecoveryFields()
        {
            return should_always_show_recovery_fields;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;

                hash = hash * 23 + current_label_width.GetHashCode();
                hash = hash * 23 + should_auto_size_labels.GetHashCode();
                hash = hash * 23 + auto_size_label_margin.GetHashCode();
                hash = hash * 23 + should_use_visibility.GetHashCode();
                hash = hash * 23 + should_always_show_recovery_fields.GetHashCode();
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