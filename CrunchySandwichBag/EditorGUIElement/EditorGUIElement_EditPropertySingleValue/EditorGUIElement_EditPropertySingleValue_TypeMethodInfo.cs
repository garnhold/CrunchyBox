using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public class EditorGUIElement_EditPropertySingleValue_TypeMethodInfo : EditorGUIElement_EditPropertySingleValue<MethodInfo>
    {
        private EditProperty_Single_Value type_property;

        private string[] option_array;
        private List<MethodInfo> options;

        protected override MethodInfo DrawValueInternal(Rect rect, MethodInfo value)
        {
            Type type;

            Rect popup_rect;

            rect.SplitByXLeftPercent(0.4f, out rect, out popup_rect);
            /*
            if (type_property.TryGetContentValues(out type))
            {
                string name = value.IfNotNull(m => m.Name);
                string new_name = EditorGUI.DelayedTextField(rect, name);

                if (new_name != name || option_array == null)
                {
                    name = new_name;

                    options.Change(
                        type.GetFilteredInstanceMethods(Filterer_MethodInfo.IsNamed(name))
                            .Convert<MethodInfoEX, MethodInfo>()
                    );
                    option_array = options.Convert(o => o.GetEffectiveParameterTypes().ToString(", ")).ToArray();

                    value = options.GetFirst();
                }

                value = options.Get(
                    EditorGUI.Popup(
                        popup_rect,
                        options.FindIndexOf(value),
                        option_array
                    )
                );
            }
            */
            return value;
        }

        public EditorGUIElement_EditPropertySingleValue_TypeMethodInfo(EditProperty_Single_Value p, EditProperty_Single_Value t) : base(p)
        {
            type_property = t;

            options = new List<MethodInfo>();
        }
    }
}