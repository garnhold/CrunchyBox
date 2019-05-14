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
    public abstract class EditProperty : IDynamicCustomAttributeProvider
    {
        private EditTarget target;

        protected virtual EditorGUIElement CreateEditorGUIElementInternal() { return null; }

        public abstract bool IsUnified();

        public abstract string GetName();
        public abstract Type GetPropertyType();

        public abstract IEnumerable<Attribute> GetAllCustomAttributes(bool inherit);

        public EditProperty(EditTarget t)
        {
            target = t;
        }

        public EditTarget GetTarget()
        {
            return target;
        }

        public EditorGUIElement CreateEditorGUIElement()
        {
            return ForTypes.GetTypeForType<EditorGUIElementForTypeAttribute>(GetPropertyType())
                .IfNotNull(t => t.CreateInstance<EditorGUIElement>(this))
                ??
                CreateEditorGUIElementInternal()
                ??
                new EditorGUIElement_Single_Text("--Unable to create GUI element for " + GetPropertyType() + "--");
        }
    }
}