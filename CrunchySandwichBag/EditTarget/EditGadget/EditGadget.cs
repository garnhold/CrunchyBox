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
    
    public class EditGadget
    {
        private EditTarget target;

        private Variable variable;

        private Dictionary<string, Action> aux_actions;
        private Dictionary<string, Variable> aux_variables;

        static public EditGadget New(EditTarget target, Variable variable, AttachEditGadgetAttribute attribute)
        {
            Type object_type = target.GetTargetType();

            return new EditGadget(target, variable,
                attribute.GetActionPaths().ConvertValuesOfPair(p => object_type.GetActionByPath(p)),
                attribute.GetVariablePaths().ConvertValuesOfPair(p => object_type.GetVariableByPath(p))
            );
        }

        protected void Touch(string label, Process process)
        {
            target.Touch(label, process);
        }

        public EditGadget(EditTarget t, Variable v, IEnumerable<KeyValuePair<string, Action>> ae, IEnumerable<KeyValuePair<string, Variable>> ve)
        {
            target = t;

            variable = v;

            aux_actions = ae.ToDictionary();
            aux_variables = ve.ToDictionary();
        }

        public void Execute(object target, string name)
        {
            Touch(name, delegate () {
                aux_actions.GetValue(name).IfNotNull(a => a.Execute(target));
            });
        }

        public void SetContents(object target, object value)
        {
            Touch("Setting " + GetName(), delegate () {
                variable.SetContents(target, value);
            });
        }

        public void SetAuxContents(object target, string name, object value)
        {
            Touch("Setting " + name, delegate () {
                aux_variables.GetValue(name).IfNotNull(v => v.SetContents(target, value));
            });
        }

        public object GetContents(object target)
        {
            return variable.GetContents(target);
        }

        public object GetAuxContents(object target, string name)
        {
            return aux_variables.GetValue(name).IfNotNull(v => v.GetContents(target));
        }

        public IEnumerable<EditGadgetInstance> GetInstances()
        {
            return target.GetObjects().Convert(o => new EditGadgetInstance(this, o));
        }

        public string GetName()
        {
            return variable.GetVariableName();
        }

        public Type GetGadgetType()
        {
            return variable.GetVariableType();
        }

        public EditTarget GetTarget()
        {
            return target;
        }

        public EditorSceneElement CreateEditorSceneElement()
        {
            return new EditorSceneElement_Complex_EditGadget(this);
        }

        public Type GetEditorSceneElementEditGadgetInstanceType()
        {
            return variable.GetCustomAttributeOfType<AttachEditGadgetAttribute>(true)
                .GetEditorSceneElementEditGadgetInstanceType();
        }

        public IEnumerable<Attribute> GetAllCustomAttributes(bool inherit)
        {
            return variable.GetAllCustomAttributes(inherit);
        }
    }
}