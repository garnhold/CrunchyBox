using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public abstract class EditProperty : IDynamicCustomAttributeProvider
    {
        private EditTarget target;

        protected virtual GUIContent CreateGUIContentLabelInternal() { return null; }
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

        public GUIContent CreateGUIContentLabel()
        {
            return CreateGUIContentLabelInternal()
                ??
                new GUIContent(
                    GetName().StyleEntityForDisplay(),
                    this.GetCustomAttributeOfType<TooltipAttribute>(true).IfNotNull(a => a.tooltip)
                );
        }

        public EditorGUIElement CreateEditorGUIElement()
        {
            return ForTypes.GetBestTypeForType<EditorGUIElementForTypeAttribute>(GetPropertyType())
                .IfNotNull(t => t.CreateInstance<EditorGUIElement>(this))
                ??
                CreateEditorGUIElementInternal()
                ??
                new EditorGUIElement_UnhandledEditProperty(this);
        }

        public override string ToString()
        {
            return GetPropertyType() + " " + GetName();
        }
    }
}