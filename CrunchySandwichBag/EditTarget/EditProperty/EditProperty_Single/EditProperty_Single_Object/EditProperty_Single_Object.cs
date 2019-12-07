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