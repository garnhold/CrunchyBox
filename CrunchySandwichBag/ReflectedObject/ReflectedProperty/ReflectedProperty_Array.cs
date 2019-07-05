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
    public class ReflectedProperty_Array : ReflectedProperty
    {
        private IEnumerable<int> GetAllCounts()
        {
            return GetAllIEnumerables().Convert(i => i.InspectCount());
        }

        private IEnumerable<IEnumerable> GetAllIEnumerables()
        {
            return GetAllContents().Convert<IEnumerable>();
        }

        public ReflectedProperty_Array(ReflectedObject o, Variable v) : base(o, v)
        {
        }

        public void EnsurePresence()
        {
            Touch("Creating " + GetVariableName(), delegate() {
                GetObjects().Process(o => {
                    if (GetContents(o) == null)
                        SetContents(o, GetVariableType().CreateInstance());
                });
            });
        }

        public void InsertElement(int index)
        {
            Touch("Inserting Element Into " + GetVariableName(), delegate() {
                GetAllIEnumerables().Process(i => i.InspectInsert(index));
            });
        }

        public void RemoveElement(int index)
        {
            Touch("Removing Element From " + GetVariableName(), delegate() {
                GetAllIEnumerables().Process(i => i.InspectRemoveAt(index));
            });
        }

        public ReflectedProperty GetElement(int index)
        {
            return ReflectedProperty.New(GetReflectedObject(), new Variable_Element(GetVariable(), index));
        }

        public bool TryGetNumberElements(out int number)
        {
            if (IsUnified())
                return GetAllCounts().TryGetFirst(out number);

            number = 0;
            return false;
        }

        public override bool IsUnified()
        {
            if (GetAllCounts().AreAllSame())
                return true;

            return false;
        }

        public Type GetElementType()
        {
            return GetVariableType().GetIEnumerableType();
        }
    }
}