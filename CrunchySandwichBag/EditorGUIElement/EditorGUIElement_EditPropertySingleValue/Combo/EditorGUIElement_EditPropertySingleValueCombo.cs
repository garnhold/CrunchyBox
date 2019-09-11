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
    public abstract class EditorGUIElement_EditPropertySingleValueCombo<T> : EditorGUIElement
    {
        private EditProperty_Single_Value property;

        public abstract IEnumerable<T> GetOptions(string text);

        protected override void DrawElementInternal(Rect view)
        {
            T old_value;

            if (property.TryGetContentValues<T>(out old_value, true))
            {
                string old_text = old_value.ToStringEX("None");
                string new_text = EditorGUI.DelayedTextField(GetElementRect(), old_text);

                if (new_text != old_text)
                {
                    List<T> options = GetOptions(new_text)
                        .Sort(o => o.ToStringEX().Length)
                        .ToList();

                    if (options.HasOnlyOne())
                        property.SetContentValues(options.GetOnly());
                    else
                    {
                        GenericMenuExtensions.Create<T>(options, o => property.SetContentValues(o))
                            .DropDown(GetElementRect());
                    }
                }
            }
            else
            {
                EditorGUI.LabelField(GetElementRect(), "(Non-Unified Value)");
            }
        }

        public EditorGUIElement_EditPropertySingleValueCombo(EditProperty_Single_Value p)
        {
            property = p;
        }

        public EditProperty_Single_Value GetProperty()
        {
            return property;
        }
    }
}