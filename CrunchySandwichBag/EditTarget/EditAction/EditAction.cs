using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Noodle;    using Sandwich;
    
    public class EditAction : IDynamicCustomAttributeProvider
    {
        private EditTarget target;
        private Action action;

        static public EditAction New(EditTarget target, Action action)
        {
            return new EditAction(target, action);
        }

        public EditAction(EditTarget o, Action a)
        {
            target = o;
            action = a;
        }

        public void Execute()
        {
            target.TouchWithUndo(GetName(), delegate () {
                target.GetObjects().Process(o => action.Execute(o));
            });
        }

        public string GetName()
        {
            return action.GetActionName();
        }

        public EditTarget GetTarget()
        {
            return target;
        }

        public EditorGUIElement CreateEditorGUIElement()
        {
            return new EditorGUIElement_EditAction_Button(this);
        }

        public IEnumerable<Attribute> GetAllCustomAttributes(bool inherit)
        {
            return action.GetAllCustomAttributes(inherit);
        }
    }
}