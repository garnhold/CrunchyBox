using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Salt;
    using Noodle;
    using Bun;
    using Sandwich;
    
    public abstract class EditProperty : IDynamicCustomAttributeProvider
    {
        private EditTarget target;

        protected virtual GUIContent CreateGUIContentLabelInternal() { return null; }
        protected virtual EditorGUIElement CreateEditorGUIElementInternal() { return null; }

        public abstract void ClearContents();
        public abstract void CreateContents(Type type);
        public abstract void EnsureContents(Type type);
        public abstract void ForceContentValues(object value);

        public abstract bool IsUnified();

        public abstract string GetName();
        public abstract Type GetPropertyType();

        public abstract IEnumerable<Attribute> GetAllCustomAttributes(bool inherit);

        public EditProperty(EditTarget t)
        {
            target = t;
        }

        public void CreateContents()
        {
            CreateContents(GetPropertyType());
        }

        public void EnsureContents()
        {
            EnsureContents(GetPropertyType());
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
            return GetPropertyType().CreateExplicitEditorGUIElementForType(this)
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