using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Salt;
    using Noodle;    using Sandwich;
    
    public class EditDisplay : IDynamicCustomAttributeProvider
    {
        private EditTarget target;
        private Variable variable;

        static public EditDisplay New(EditTarget target, Variable variable)
        {
            return new EditDisplay(target, variable);
        }

        public EditDisplay(EditTarget t, Variable v)
        {
            target = t;
            variable = v;
        }

        public string GetName()
        {
            return variable.GetVariableName();
        }

        public IEnumerable<object> GetValues()
        {
            return target.GetObjects().Convert(delegate (object obj) {
                try
                {
                    return variable.GetContents(obj);
                }
                catch (Exception ex)
                {
                    return ex;
                }
            });
        }

        public bool TryGetValue(out object value)
        {
            return GetValues().AreAllSame(out value);
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

        public IEnumerable<Attribute> GetAllCustomAttributes(bool inherit)
        {
            return variable.GetAllCustomAttributes(inherit);
        }
    }
}