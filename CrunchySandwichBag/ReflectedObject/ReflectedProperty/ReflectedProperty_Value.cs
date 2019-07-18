using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;
using CrunchyRecipe;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public class ReflectedProperty_Value : ReflectedProperty
    {
        public ReflectedProperty_Value(ReflectedObject o, Variable v) : base(o, v)
        {
        }

        public void SetContents(object value)
        {
            Touch("Setting " + GetVariableName(), delegate() {
                if (GetVariableType().IsReferenceType() && value != null)
                {
                    Type type = value.GetTypeEX();
                    List<object> external_objects = new List<object>();
                    string data = UnityTyonSerializer.INSTANCE.SerializeValue(value, type, external_objects);

                    GetObjects().Process(o => SetContents(o, UnityTyonSerializer.INSTANCE.DeserializeValue(data, type, external_objects)));
                }
                else
                {
                    GetObjects().Process(o => SetContents(o, value));
                }
            });
        }

        public bool TryGetContents(out object value)
        {
            if (IsUnified())
                return GetAllContents().TryGetFirst(out value);

            value = null;
            return false;
        }

        public bool TryGetContents(out ReflectedObject value)
        {
            value = new ReflectedObject(GetAllContents(), GetReflectedObject());

            if (value.IsValid())
                return true;

            return false;
        }

        public bool TryGetContents<T>(out T value)
        {
            object temp;

            if (TryGetContents(out temp))
            {
                if (temp.Convert<T>(out value))
                    return true;
            }

            value = default(T);
            return false;
        }

        public override bool IsUnified()
        {
            if (GetAllContents().AreAllSame())
                return true;

            return false;
        }
    }
}