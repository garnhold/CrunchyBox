using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    public class Signal_Periodic_Multiple_Composite : Signal_Periodic_Multiple
    {
        protected override float ExecuteInternal(float input)
        {
            return GetFunctions().Apply(input, (i, f) => f.Execute(i));
        }
    }
}