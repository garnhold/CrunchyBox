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

    public partial class ReflectedGadget : IDynamicCustomAttributeProvider
    {
        private ReflectedObject reflected_object;

        private Variable variable;

        private Dictionary<string, Action> aux_actions;
        private Dictionary<string, Variable> aux_variables;

        static public ReflectedGadget New(ReflectedObject reflected_object, Variable variable, AttachEditGadgetAttribute attribute)
        {
            Type object_type = reflected_object.GetObjectType();

            return new ReflectedGadget(reflected_object, variable, 
                attribute.GetActionPaths().ConvertValuesOfPair(p => object_type.GetActionByPath(p)),
                attribute.GetVariablePaths().ConvertValuesOfPair(p => object_type.GetVariableByPath(p))
            );
        }

        protected void Execute(object target, string name)
        {
            Touch(name, delegate() {
                aux_actions.GetValue(name).IfNotNull(a => a.Execute(target));
            });
        }

        protected void SetContents(object target, object value)
        {
            Touch("Setting " + GetVariableName(), delegate() {
                variable.SetContents(target, value);
            });
        }

        protected void SetAuxContents(object target, string name, object value)
        {
            Touch("Setting " + name, delegate() {
                aux_variables.GetValue(name).IfNotNull(v => v.SetContents(target, value));
            });
        }

        protected object GetContents(object target)
        {
            return variable.GetContents(target);
        }

        protected object GetAuxContents(object target, string name)
        {
            return aux_variables.GetValue(name).IfNotNull(v => v.GetContents(target));
        }

        protected void Touch(string label, Process process)
        {
            reflected_object.Touch(label, process);
        }

        public ReflectedGadget(ReflectedObject o, Variable v, IEnumerable<KeyValuePair<string, Action>> ae, IEnumerable<KeyValuePair<string, Variable>> ve)
        {
            reflected_object = o;

            variable = v;

            aux_actions = ae.ToDictionary();
            aux_variables = ve.ToDictionary();
        }

        public ReflectedObject GetReflectedObject()
        {
            return reflected_object;
        }

        public Variable GetVariable()
        {
            return variable;
        }

        public Type GetVariableType()
        {
            return variable.GetVariableType();
        }

        public IEnumerable<Instance> GetInstances()
        {
            return reflected_object.GetObjects().Convert(o => new Instance(this, o));
        }

        public string GetVariableName()
        {
            return variable.GetVariableName();
        }

        public IEnumerable<Attribute> GetAllCustomAttributes(bool inherit)
        {
            return variable.GetAllCustomAttributes(inherit);
        }
    }
}