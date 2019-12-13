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
    
    public abstract class EditProperty_Array : EditProperty
    {
        public abstract void InsertElement(int index);
        public abstract void RemoveElement(int index);
        public abstract void MoveElement(int src_index, int dst_index);

        public abstract EditProperty GetElement(int index);
        public abstract bool TryGetNumberElements(out int number);

        public abstract int GetIndexOfElement(EditProperty element);

        public abstract Type GetElementType();

        protected override EditorGUIElement CreateEditorGUIElementInternal()
        {
            return new EditorGUIElement_Complex_EditPropertyArray_Generic(this);
        }

        public EditProperty_Array(EditTarget t) : base(t)
        {
        }

        public void InsertElementBefore(EditProperty element)
        {
            InsertElement(GetIndexOfElement(element));
        }

        public void InsertElementAfter(EditProperty element)
        {
            InsertElement(GetIndexOfElement(element) + 1);
        }

        public void RemoveElement(EditProperty element)
        {
            RemoveElement(GetIndexOfElement(element));
        }

        public void MoveElement(EditProperty element, int index)
        {
            MoveElement(GetIndexOfElement(element), index);
        }
    }
}