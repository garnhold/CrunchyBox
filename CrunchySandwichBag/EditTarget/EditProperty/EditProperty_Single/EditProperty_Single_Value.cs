using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Noodle;
    using Bun;
    using Sandwich;
    
    public class EditProperty_Single_Value : EditProperty_Single
    {
        protected override EditorGUIElement CreateEditorGUIElementInternal()
        {
            return new EditorGUIElement_Composite_EditPropertySingleValue_Generic(this);
        }

        public EditProperty_Single_Value(EditTarget t, Variable v) : base(t, v)
        {
        }

        public void SetContentValues(object value)
        {
            if (IsUnified())
                ForceContentValues(value);
        }

        public bool TryGetContentValues(out object value)
        {
            if (IsUnified())
                return GetAllContents().TryGetFirst(out value);

            value = null;
            return false;
        }
        public bool TryGetContentValues<T>(out T value, bool allow_null_object = false)
        {
            object temp;

            if (TryGetContentValues(out temp))
            {
                if (temp.ConvertEX<T>(out value, allow_null_object))
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

        public override bool IsUnified()
        {
            if (GetAllContents().AreAllSame())
                return true;

            return false;
        }
    }
}