using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
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
                    variable.HasCustomAttributeOfType<PolymorphicFieldAttribute>(true) &&
                    variable_type.IsTypicalValueType() == false &&
                    variable_type.CanBeTreatedAs<UnityEngine.Object>() == false
                    )
                {
                    return new ReflectedProperty_Single_Object(reflected_object, variable);
                }

                return new ReflectedProperty_Single_Value(reflected_object, variable);
            }
        }

        protected void SetContents(object obj, object value)
        {
            variable.SetContents(obj, value);
        }
        protected object GetContents(object obj)
        {
            return variable.GetContents(obj);
        }

        protected IEnumerable<object> GetAllContents()
        {
            return GetObjects().Convert(o => GetContents(o));
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
                GetObjects().Process(o => SetContents(o, null));
            });
        }

        public void CreateContents(Type type)
        {
            Touch("Creating " + GetVariableName(), delegate() {
                GetObjects().Process(o => SetContents(o, type.CreateBlankValue()));
            });
        }

        public void EnsureContents(Type type)
        {
            Touch("Creating " + GetVariableName(), delegate() {
                GetObjects().Process(o => {
                    if (GetContents(o).GetTypeEX() != type)
                        SetContents(o, GetContents(o).ConvertEX(type) ?? type.CreateBlankValue());
                });
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
                    GetObjects().Process(o => SetContents(o, value));
                else
                {
                    UnityTyonReplayer replayer = new UnityTyonReplayer(value);

                    GetObjects().Process(o => SetContents(o, replayer.CreateInstance()));
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