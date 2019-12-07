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
    
    public abstract class EditorGUIElement_Popup : EditorGUIElement_Single
    {
        public EditorGUIElement_Popup(float h) : base(h) { }
        public EditorGUIElement_Popup() : this(DEFAULT_HEIGHT) { }
    }

    public abstract class EditorGUIElement_Popup<T> : EditorGUIElement_Popup
    {
        private List<T> elements;
        private Operation<string, T> operation;

        public abstract bool TryGetSelectedElement(out T element);
        public abstract void SetSelectedElement(T element);

        protected int ConvertElementToIndex(T element)
        {
            return GetElements().FindIndexOf(element);
        }
        protected T ConvertIndexToElement(int index)
        {
            return GetElements().Get(index);
        }

        protected int PopupIndex(Rect rect, int index)
        {
            return EditorGUI.Popup(rect, index, GetElementStrings().ToArray());
        }
        protected T PopupElement(Rect rect, T element)
        {
            return ConvertIndexToElement(PopupIndex(rect, ConvertElementToIndex(element)));
        }

        protected override bool DrawSingleInternal(Rect rect)
        {
            T old_value;

            if (TryGetSelectedElement(out old_value))
            {
                T new_value = PopupElement(rect, old_value);

                if (new_value.NotEqualsEX(old_value))
                    SetSelectedElement(new_value);

                return true;
            }

            return false;
        }

        public EditorGUIElement_Popup(IEnumerable<T> es, Operation<string, T> o, float h) : base(h)
        {
            elements = es.ToList();
            operation = o;
        }

        public EditorGUIElement_Popup(IEnumerable<T> es, Operation<string, T> o) : this(es, o, DEFAULT_HEIGHT) { }
        public EditorGUIElement_Popup(IEnumerable<T> es) : this(es, e => e.ToStringEX()) { }

        public bool TryGetSelectedElementIndex(out int index)
        {
            T element;

            if (TryGetSelectedElement(out element))
            {
                index = ConvertElementToIndex(element);
                return true;
            }

            index = -1;
            return false;
        }

        public IEnumerable<T> GetElements()
        {
            return elements;
        }

        public IEnumerable<string> GetElementStrings()
        {
            return GetElements().Convert(operation);
        }
    }
}