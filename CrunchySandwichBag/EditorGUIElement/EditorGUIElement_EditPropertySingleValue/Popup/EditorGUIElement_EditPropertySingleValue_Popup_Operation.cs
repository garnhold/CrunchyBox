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
    public class EditorGUIElement_EditPropertySingleValue_Popup_Operation<T> : EditorGUIElement_EditPropertySingleValue_Popup<T>
    {
        private Operation<IEnumerable<T>> operation;

        public EditorGUIElement_EditPropertySingleValue_Popup_Operation(EditProperty_Single_Value p, Operation<IEnumerable<T>> o) : base(p)
        {
            operation = o;
        }

        public override IEnumerable<T> GetOptions()
        {
            return operation();
        }
    }
}