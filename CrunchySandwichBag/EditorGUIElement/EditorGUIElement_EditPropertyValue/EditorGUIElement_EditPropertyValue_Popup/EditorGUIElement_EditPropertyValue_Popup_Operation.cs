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
    public class EditorGUIElement_EditPropertyValue_Popup_Operation<T> : EditorGUIElement_EditPropertyValue_Popup<T>
    {
        private Operation<IEnumerable<T>> operation;

        public EditorGUIElement_EditPropertyValue_Popup_Operation(EditProperty_Value p, Operation<IEnumerable<T>> o) : base(p)
        {
            operation = o;
        }

        public override IEnumerable<T> GetOptions()
        {
            return operation();
        }
    }
}