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
    public abstract class EditProperty_Single_Object : EditProperty_Single
    {
        protected override EditorGUIElement CreateEditorGUIElementInternal()
        {
            return new EditorGUIElement_Complex_EditPropertySingleObject_Generic(this);
        }

        public EditProperty_Single_Object(EditTarget t) : base(t)
        {
        }
    }
}