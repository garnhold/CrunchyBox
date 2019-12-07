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
    
    public abstract class EditFunction : IDynamicCustomAttributeProvider
    {
        private EditTarget target;

        public abstract void Execute();
        public abstract IEnumerable<EditProperty> GetParameters();

        public abstract string GetName();
        public abstract IEnumerable<Attribute> GetAllCustomAttributes(bool inherit);

        public EditFunction(EditTarget t)
        {
            target = t;
        }

        public EditTarget GetTarget()
        {
            return target;
        }

        public EditorGUIElement CreateEditorGUIElement()
        {
            return new EditorGUIElement_EditFunction_Button(this);
        }
    }
}