using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    using Cheese;
    
    public class Signal_Periodic_MExp : Signal_Periodic_Typical
    {
        [SerializeFieldEX]private string equation;

        private string compiled_equation;
        private Operation<float, float> operation;

        private void OnValidate()
        {
            operation = null;
        }

        protected override float ExecuteInternal(float input)
        {
            if (equation != compiled_equation)
            {
                compiled_equation = equation;
                operation = MExp.GetOperation(equation, "x");
            }

            return operation(input);
        }
    }
}