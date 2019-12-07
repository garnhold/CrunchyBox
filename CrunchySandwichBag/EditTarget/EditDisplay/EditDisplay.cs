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
    
    public abstract class EditDisplay : IDynamicCustomAttributeProvider
    {
        private EditTarget target;

        public abstract string GetName();
        public abstract IEnumerable<object> GetValues();
        public abstract bool TryGetValue(out object value);
        public abstract IEnumerable<Attribute> GetAllCustomAttributes(bool inherit);

        public EditDisplay(EditTarget t)
        {
            target = t;
        }

        public EditTarget GetTarget()
        {
            return target;
        }

        public GUIContent CreateGUIContentLabel()
        {
            return new GUIContent(
                GetName().StyleEntityForDisplay(),
                    this.GetCustomAttributeOfType<TooltipAttribute>(true).IfNotNull(a => a.tooltip)
            );
        }

        public EditorGUIElement CreateEditorGUIElement()
        {
            return new EditorGUIElement_EditDisplay_Text(this);
        }
    }
}