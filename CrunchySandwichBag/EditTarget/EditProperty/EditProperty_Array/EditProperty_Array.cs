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
    
    public class EditProperty_Array : EditProperty
    {
        private Dictionary<int, EditPropertyArrayElement> elements_by_index;

        protected override EditorGUIElement CreateEditorGUIElementInternal()
        {
            return new EditorGUIElement_Complex_EditPropertyArray_Generic(this);
        }

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

        public EditProperty_Array(EditTarget t, Variable v) : base(t, v)
        {
            elements_by_index = new Dictionary<int, EditPropertyArrayElement>();
        }

        public void InsertElement(int index)
        {
            Touch("Inserting Element Into " + GetName(), delegate () {
                GetVariables().Process(v => v.InsertElementIntoVariableInstanceAt(index));

                ShiftIndexs(index, 1);
            });
        }

        public void RemoveElement(int index)
        {
            Touch("Removing Element From " + GetName(), delegate () {
                GetVariables().Process(v => v.RemoveElementInVariableInstanceAt(index));

                elements_by_index.Remove(index);
                ShiftIndexs(index, -1);
            });
        }

        public void MoveElement(int src, int dst)
        {
            Touch("Moving Element Within " + GetName() + " From " + src + " to " + dst, delegate () {
                GetVariables().Process(v => v.MoveElementInVariableInstance(src, dst));

                EditPropertyArrayElement element = elements_by_index.RemoveAndGet(src);

                ShiftIndexs(src, dst, -1);

                element.SetIndex(dst);
                elements_by_index.Add(element.GetIndex(), element);
            });
        }

        public EditProperty GetElement(int index)
        {
            EnsureContents();

            return elements_by_index.GetOrCreateValue(index,
                i => new EditPropertyArrayElement(GetTarget(), GetVariable(), i)
            )
            .GetProperty();
        }

        public int GetIndexOfElement(EditProperty element)
        {
            return elements_by_index.Values
                .FindFirst(e => e.GetProperty() == element)
                .IfNotNull(e => e.GetIndex(), -1);
        }

        public bool TryGetNumberElements(out int number)
        {
            EnsureContents();

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
            return GetPropertyType().GetIEnumerableType();
        }
    }
}