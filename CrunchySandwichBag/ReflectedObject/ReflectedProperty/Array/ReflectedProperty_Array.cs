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
    
    public class ReflectedProperty_Array : ReflectedProperty
    {
        private Dictionary<int, ReflectedPropertyArrayElement> elements_by_index;

        private IEnumerable<int> GetAllCounts()
        {
            return GetVariables().Convert(v => v.GetVariableInstanceNumberElements());
        }

        private void ShiftIndexs(int start_index, int final_index, int amount)
        {
            if (final_index < start_index)
            {
                Swap.Values(ref start_index, ref final_index);
                amount = -amount;
            }

            elements_by_index.Values
                .Narrow(e => e.GetIndex() >= start_index && e.GetIndex() <= final_index)
                .Process(e => e.AdjustIndex(amount));

            UpdateIndexs();
        }
        private void ShiftIndexs(int index, int amount)
        {
            ShiftIndexs(index, int.MaxValue, amount);
        }

        private void UpdateIndexs()
        {
            elements_by_index = elements_by_index.Values.ToDictionaryValues(e => e.GetIndex());
        }

        public ReflectedProperty_Array(ReflectedObject o, Variable v) : base(o, v)
        {
            elements_by_index = new Dictionary<int, ReflectedPropertyArrayElement>();
        }

        public void InsertElement(int index)
        {
            Touch("Inserting Element Into " + GetVariableName(), delegate() {
                GetVariables().Process(v => v.InsertElementIntoVariableInstanceAt(index));

                ShiftIndexs(index, 1);
            });
        }
        public void InsertElementBefore(ReflectedProperty element)
        {
            InsertElement(GetIndexOfElement(element));
        }
        public void InsertElementAfter(ReflectedProperty element)
        {
            InsertElement(GetIndexOfElement(element) + 1);
        }

        public void RemoveElement(int index)
        {
            Touch("Removing Element From " + GetVariableName(), delegate() {
                GetVariables().Process(v => v.RemoveElementInVariableInstanceAt(index));

                elements_by_index.Remove(index);
                ShiftIndexs(index, -1);
            });
        }
        public void RemoveElement(ReflectedProperty element)
        {
            RemoveElement(GetIndexOfElement(element));
        }

        public void MoveElement(int src, int dst)
        {
            Touch("Moving Element Within " + GetVariableName() + " From " + src + " to " + dst, delegate() {
                GetVariables().Process(v => v.MoveElementInVariableInstance(src, dst));

                ReflectedPropertyArrayElement element = elements_by_index.RemoveAndGet(src);

                ShiftIndexs(src, dst, -1);

                element.SetIndex(dst);
                elements_by_index.Add(element.GetIndex(), element);
            });
        }
        public void MoveElement(ReflectedProperty element, int dst)
        {
            MoveElement(GetIndexOfElement(element), dst);
        }

        public ReflectedProperty GetElement(int index)
        {
            return elements_by_index.GetOrCreateValue(index, 
                i => new ReflectedPropertyArrayElement(GetReflectedObject(), GetVariable(), i)
            )
            .GetProperty();
        }

        public int GetIndexOfElement(ReflectedProperty element)
        {
            return elements_by_index.Values
                .FindFirst(e => e.GetProperty() == element)
                .IfNotNull(e => e.GetIndex(), -1);
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