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
        private Variable variable;

        public abstract bool IsUnified();

        protected virtual GUIContent CreateGUIContentLabelInternal() { return null; }
        protected virtual EditorGUIElement CreateEditorGUIElementInternal() { return null; }

        static public EditProperty New(EditTarget target, Variable variable)
        {
            Type variable_type = variable.GetVariableType();

            if (variable_type.IsTypicalIEnumerable())
                return new EditProperty_Array(target, variable);

            if (
                variable.HasCustomAttributeOfType<ObjectSignifyFieldAttribute>(true) &&
                variable_type.IsTypicalValueType() == false &&
                variable_type.CanBeTreatedAs<UnityEngine.Object>() == false
                )
            {
                return new EditProperty_Single_Object(target, variable);
            }

            return new EditProperty_Single_Value(target, variable);
        }

        protected IEnumerable<object> GetObjects()
        {
            return target.GetObjects();
        }

        protected IEnumerable<object> GetAllContents()
        {
            return GetObjects().Convert(o => variable.GetContents(o));
        }

        protected IEnumerable<Type> GetAllContentTypes()
        {
            return GetAllContents().Convert(o => o.GetTypeEX());
        }

        protected IEnumerable<VariableInstance> GetVariables()
        {
            return GetObjects().Convert(o => variable.CreateStrongInstance(o));
        }

        public EditProperty(EditTarget t, Variable v)
        {
            target = t;
            variable = v;
        }

        public void ClearContents(bool create_undo_state)
        {
            target.Touch("Clearing " + GetName(), create_undo_state, delegate() {
                return GetVariables().ProcessOR(v => v.ClearContents().IsChange());
            });
        }

        public void CreateContents(Type type, bool create_undo_state)
        {
            target.Touch("Creating " + GetName(), create_undo_state, delegate() {
                return GetVariables().ProcessOR(v => v.CreateContents(type).IsChange());
            });
        }

        public void EnsureContents(Type type, bool create_undo_state)
        {
            target.Touch("Creating " + GetName(), create_undo_state, delegate() {
                return GetVariables().ProcessOR(v => v.EnsureContents(type).IsChange());
            });
        }
        public void EnsureContents(bool create_undo_state)
        {
            EnsureContents(GetPropertyType(), create_undo_state);
        }

        public void ForceContentValues(object value)
        {
            target.TouchWithUndo("Setting " + GetName(), delegate () {
                if (GetPropertyType().IsReferenceFreeType())
                    GetVariables().Process(v => v.SetContents(value));
                else
                {
                    UnityTyonReplayer replayer = new UnityTyonReplayer(value);

                    GetVariables().Process(v => v.SetContents(replayer.CreateInstance()));
                }
            });
        }

        public string GetName()
        {
            return variable.GetVariableName();
        }

        public Type GetPropertyType()
        {
            return variable.GetVariableType();
        }

        public Variable GetVariable()
        {
            return variable;
        }

        public bool TryGetContentsType(out Type type)
        {
            if (GetAllContentTypes().AreAllSame(out type))
                return true;

            type = null;
            return false;
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

        public IEnumerable<Attribute> GetAllCustomAttributes(bool inherit)
        {
            return variable.GetAllCustomAttributes(inherit);
        }
    }
}