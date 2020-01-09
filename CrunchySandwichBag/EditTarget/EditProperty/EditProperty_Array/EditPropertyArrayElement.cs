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
    
    public class EditPropertyArrayElement
    {
        private EditProperty property;
        private Variable_Element variable;

        public EditPropertyArrayElement(EditTarget t, Variable v, int i)
        {
            variable = v.GetVariableElement(i);
            property = EditProperty.New(t, variable);
        }

        public void SetIndex(int index)
        {
            variable.SetElementIndex(index);
        }

        public void AdjustIndex(int amount)
        {
            SetIndex(GetIndex() + amount);
        }

        public int GetIndex()
        {
            return variable.GetElementIndex();
        }

        public EditProperty GetProperty()
        {
            return property;
        }
    }
}