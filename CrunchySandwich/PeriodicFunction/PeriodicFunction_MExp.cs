using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;
using CrunchyCheese;

namespace CrunchySandwich
{
    public class PeriodicFunction_MExp : PeriodicFunction
    {
        [SerializeField]private string equation;

        private Operation<float, float> operation;

        private void OnValidate()
        {
            operation = null;
        }

        protected override float ExecuteInternal(float input)
        {
            if (operation == null)
                operation = MExp.GetOperation(equation, "x");

            return operation(input);
        }
    }
}