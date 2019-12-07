using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    public class Signal_Periodic_Multiple_Sum : Signal_Periodic_Multiple
    {
        protected override float ExecuteInternal(float input)
        {
            return GetFunctions().Convert(f => f.Execute(input)).Sum();
        }
    }
}