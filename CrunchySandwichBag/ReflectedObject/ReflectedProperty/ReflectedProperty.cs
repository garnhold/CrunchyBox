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
    
    public abstract class ReflectedProperty : IDynamicCustomAttributeProvider
    {
        private ReflectedObject reflected_object;
        private Variable variable;

        public abstract bool IsUnified();

        static public ReflectedProperty New(ReflectedObject reflected_object, Variable variable)
        {
            Type variable_type = variable.GetVariableType();

            if (variable_type.IsTypicalIEnumerable())
                return new ReflectedProperty_Array(reflected_object, variable);
            else
            {
                if (
                    variable.HasCustomAttributeOfType<ObjectSignifyFieldAttribute>(true) &&
                    variable_type.IsTypicalValueType() == false &&
                    variable_type.CanBeTreatedAs<UnityEngine.Object>() == false
                    )
                {
                    return new ReflectedProperty_Single_Object(reflected_object, variable);
                }

                return new ReflectedProperty_Single_Value(reflected_object, variable);
            }
        }

        protected IEnumerable<VariableInstance> GetVariables()
        {
            return GetObjects().Convert(o => variable.CreateStrongInstance(o));
        }

        protected IEnumerable<object> GetAllContents()
        {
            return GetObjects().Convert(o => variable.GetContents(o));
        }

        protected IEnumerable<Type> GetAllContentTypes()
        {
            return GetAllContents().Convert(o => o.GetTypeEX());
        }

        protected IEnumerable<object> GetObjects()
        {
            return reflected_object.GetObjects();
        }

        protected void Touch(string label, Process process)
        {
            reflected_object.Touch(label, process);
        }

        public ReflectedProperty(ReflectedObject o, Variable v)
        {
            reflected_object = o;
            variable = v;
        }

        public void ClearContents()
        {
            Touch("Clearing " + GetVariableName(), delegate() {
                GetVariables().Process(v => v.ClearContents());
            });
        }

        public void CreateContents(Type type)
        {
            Touch("Creating " + GetVariableName(), delegate() {
                GetVariables().Process(v => v.CreateContents(type));
            });
        }

        public void EnsureContents(Type type)
        {
            Touch("Creating " + GetVariableName(), delegate() {
                GetVariables().Process(v => v.EnsureContents(type));
            });
        }
        public void EnsureContents()
        {
            EnsureContents(GetVariableType());
        }

        public void ForceContentValues(object value)
        {
            Touch("Setting " + GetVariableName(), delegate() {
                if (GetVariableType().IsPrimitive())
                    GetVariables().Process(v => v.SetContents(value));
                else
                {
                    UnityTyonReplayer replayer = new UnityTyonReplayer(value);

                    GetVariables().Process(v => v.SetContents(replayer.CreateInstance()));
                }
            });
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

        public bool TryGetContentsType(out Type type)
        {
            if (IsTypeUnified())
                return GetAllContentTypes().TryGetFirst(out type);

            type = null;
            return false;
        }

        public bool IsTypeUnified()
        {
            if (GetAllContentTypes().AreAllSame())
                return true;

            return false;
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