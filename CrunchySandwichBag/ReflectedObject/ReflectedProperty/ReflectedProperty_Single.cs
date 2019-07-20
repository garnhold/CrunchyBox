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
    public abstract class ReflectedProperty_Single : ReflectedProperty
    {
        public ReflectedProperty_Single(ReflectedObject o, Variable v) : base(o, v) { }

        public void ClearContents()
        {
            Touch("Clearing " + GetVariableName(), delegate() {
                GetObjects().Process(o => SetContents(o, null));
            });
        }

        public void CreateContents(Type type)
        {
            Touch("Creating " + GetVariableName(), delegate() {
                GetObjects().Process(o => SetContents(o, type.CreateInstance()));
            });
        }

        public void EnsureContents(Type type)
        {
            Touch("Creating " + GetVariableName(), delegate() {
                GetObjects().Process(o => {
                    if (GetContents(o).GetTypeEX() != type)
                        SetContents(o, type.CreateInstance());
                });
            });
            
        }
        public void EnsureContents()
        {
            EnsureContents(GetVariableType());
        }

        public bool TryGetContents(out ReflectedObject value)
        {
            value = new ReflectedObject(GetAllContents(), GetReflectedObject());

            if (value.IsValid())
                return true;

            return false;
        }
    }
}