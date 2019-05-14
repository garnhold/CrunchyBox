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
    public abstract class EditorGUIElement_Popup_SerializedProperty_Represented<ELEMENT_TYPE, SURROGATE_TYPE> : EditorGUIElement_Popup_SerializedProperty<ELEMENT_TYPE>
    {
        private Operation<SURROGATE_TYPE, ELEMENT_TYPE> operation;

        public abstract void SetSelectedElementSurrogate(SURROGATE_TYPE surrogate);
        public abstract SURROGATE_TYPE GetSelectedElementSurrogate();

        protected int ConvertSurrogateToIndex(SURROGATE_TYPE surrogate)
        {
            return GetElementSurrogates().FindIndexOf(surrogate);
        }
        protected ELEMENT_TYPE ConvertSurrogateToElement(SURROGATE_TYPE surrogate)
        {
            return ConvertIndexToElement(ConvertSurrogateToIndex(surrogate));
        }

        protected SURROGATE_TYPE ConvertIndexToSurrogate(int index)
        {
            return GetElementSurrogates().Get(index);
        }
        protected SURROGATE_TYPE ConvertElementToSurrogate(ELEMENT_TYPE element)
        {
            return ConvertIndexToSurrogate(ConvertElementToIndex(element));
        }

        public EditorGUIElement_Popup_SerializedProperty_Represented(SerializedProperty s, IEnumerable<ELEMENT_TYPE> es, Operation<SURROGATE_TYPE, ELEMENT_TYPE> o1, Operation<string, ELEMENT_TYPE> o2, float h) : base(s, es, o2, h)
        {
            operation = o1;
        }

        public EditorGUIElement_Popup_SerializedProperty_Represented(SerializedProperty s, IEnumerable<ELEMENT_TYPE> es, Operation<SURROGATE_TYPE, ELEMENT_TYPE> o1, Operation<string, ELEMENT_TYPE> o2) : this(s, es, o1, o2, EditorGUIElement_Single_Text.DEFAULT_HEIGHT) { }
        public EditorGUIElement_Popup_SerializedProperty_Represented(SerializedProperty s, IEnumerable<ELEMENT_TYPE> es, Operation<SURROGATE_TYPE, ELEMENT_TYPE> o1) : this(s, es, o1, e => e.ToStringEX()) { }

        public override void SetSelectedElement(ELEMENT_TYPE element)
        {
            SetSelectedElementSurrogate(ConvertElementToSurrogate(element));
        }

        public override ELEMENT_TYPE GetSelectedElement()
        {
            return ConvertSurrogateToElement(GetSelectedElementSurrogate());
        }

        public IEnumerable<SURROGATE_TYPE> GetElementSurrogates()
        {
            return GetElements().Convert(operation);
        }
    }
}