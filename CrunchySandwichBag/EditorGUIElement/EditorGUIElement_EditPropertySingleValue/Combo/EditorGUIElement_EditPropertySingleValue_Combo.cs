using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Bun;
    using Sandwich;
    
    public abstract class EditorGUIElement_EditPropertySingleValue_Combo<T> : EditorGUIElement_EditPropertySingleValue<T>
    {
        public abstract IEnumerable<T> GetOptions(string text);

        protected override void DrawUnifiedElementInternal(Rect rect, T old_value)
        {
            string old_text = old_value.ToStringEX("None");
            string new_text = EditorGUI.DelayedTextField(GetElementRect(), old_text);

            if (new_text != old_text)
            {
                List<T> options = GetOptions(new_text)
                    .Sort(o => o.ToStringEX().Length)
                    .ToList();

                if (options.HasOnlyOne())
                    GetProperty().SetContentValues(options.GetOnly());
                else
                {
                    GenericMenuExtensions.Create<T>(options.Prepend(default(T)), o => GetProperty().SetContentValues(o))
                        .DropDown(GetElementRect());
                }
            }
        }

        public EditorGUIElement_EditPropertySingleValue_Combo(EditProperty_Single_Value p) : base(p) { }
    }
}