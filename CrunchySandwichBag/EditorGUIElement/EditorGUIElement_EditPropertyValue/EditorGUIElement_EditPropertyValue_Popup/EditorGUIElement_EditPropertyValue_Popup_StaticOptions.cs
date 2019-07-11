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
    public abstract class EditorGUIElement_EditPropertyValue_Popup_StaticOptions<T> : EditorGUIElement_EditPropertyValue_Popup<T>
    {
        private List<T> options;

        public EditorGUIElement_EditPropertyValue_Popup_StaticOptions(EditProperty_Value p, IEnumerable<T> o) : base(p)
        {
            options = o.ToList();
        }

        public EditorGUIElement_EditPropertyValue_Popup_StaticOptions(EditProperty_Value p, params T[] o) : this(p, (IEnumerable<T>)o) { }

        public override IEnumerable<T> GetOptions()
        {
            return options;
        }
    }
}