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
    public abstract class EditProperty_Object : EditProperty
    {
        public abstract void ClearContents();
        public abstract void CreateContents(Type type);
        public abstract void EnsureContents(Type type);

        public abstract bool TryGetContents(out EditTarget value);
        public abstract bool TryGetContentsType(out Type type);

        protected override EditorGUIElement CreateEditorGUIElementInternal()
        {
            return new EditorGUIElement_Complex_EditPropertyObject_Generic(this);
        }

        public EditProperty_Object(EditTarget t) : base(t)
        {
        }
    }
}