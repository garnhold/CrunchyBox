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
    public class ReflectedProperty_Single_Value : ReflectedProperty_Single
    {
        public ReflectedProperty_Single_Value(ReflectedObject o, Variable v) : base(o, v)
        {
        }

        public void ForceContentValues(object value)
        {
            Touch("Setting " + GetVariableName(), delegate() {
                if (GetVariableType().IsReferenceType() && value != null)
                {
                    Type type = value.GetTypeEX();
                    TyonContext context = UnityTyonSettings.INSTANCE.CreateContext();

                    string data = context.SerializeValue(value, type);

                    GetObjects().Process(o => SetContents(o, context.DeserializeValue(data, type)));
                }
                else
                {
                    GetObjects().Process(o => SetContents(o, value));
                }
            });
        }

        public void SetContentValues(object value)
        {
            if (IsUnified())
                ForceContentValues(value);
        }

        public bool TryGetContentValues(out object value)
        {
            if (IsUnified())
                return GetAllContents().TryGetFirst(out value);

            value = null;
            return false;
        }

        public bool TryGetContentValues<T>(out T value)
        {
            object temp;

            if (TryGetContentValues(out temp))
            {
                if (temp.Convert<T>(out value))
                    return true;
            }

            value = default(T);
            return false;
        }

        public ReflectedObject GetContents()
        {
            ReflectedObject value;

            EnsureContents();
            TryGetContents(out value);
            return value;
        }

        public override bool IsUnified()
        {
            if (GetAllContents().AreAllSame())
                return true;

            return false;
        }
    }
}