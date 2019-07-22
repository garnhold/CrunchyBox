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
    public abstract class EditProperty_Single_Value : EditProperty_Single
    {
        public abstract void ForceContentValues(object value);
        public abstract bool TryGetContentValues(out object value);

        protected override EditorGUIElement CreateEditorGUIElementInternal()
        {
            return new EditorGUIElement_Composite_EditPropertySingleValue_EditTarget_Generic(this);
        }

        public EditProperty_Single_Value(EditTarget t) : base(t)
        {
        }

        public void SetContentValues(object value)
        {
            if (IsUnified())
                ForceContentValues(value);
        }

        public bool TryGetContentValues<T>(out T value)
        {
            object temp;

            if (TryGetContentValues(out temp))
            {
                if (temp.Convert<T>(out value, true))
                    return true;
            }

            value = default(T);
            return false;
        }

        public EditTarget GetContents()
        {
            EditTarget value;

            EnsureContents();
            TryGetContents(out value);
            return value;
        }
    }
}