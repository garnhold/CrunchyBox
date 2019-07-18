using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public abstract class EditProperty_Value : EditProperty
    {
        public abstract void SetContents(object value);

        public abstract bool TryGetContents(out object value);
        public abstract bool TryGetContents(out EditTarget value);
        public abstract bool TryGetContentsType(out Type type);

        protected override EditorGUIElement CreateEditorGUIElementInternal()
        {
            return new EditorGUIElement_Composite_EditPropertyValue_EditTarget_Generic(this);
        }

        public EditProperty_Value(EditTarget t) : base(t)
        {
        }

        public bool TryGetContents<T>(out T value)
        {
            object temp;

            if (TryGetContents(out temp))
            {
                if (temp.Convert<T>(out value, true))
                    return true;
            }

            value = default(T);
            return false;
        }
    }
}