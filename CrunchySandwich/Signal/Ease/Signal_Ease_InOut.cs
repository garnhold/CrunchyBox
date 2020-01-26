using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    public class Signal_Ease_InOut : Signal_Ease_Typical
    {
        [SerializeFieldEX][PolymorphicField]private Signal_EaseShape in_ease;
        [SerializeFieldEX][PolymorphicField]private Signal_EaseShape out_ease;

        protected override float ExecuteInternal(float input)
        {
            if (in_ease != null)
            {
                if (out_ease != null)
                    return EaseOperations.InOut(input, in_ease.Execute, out_ease.Execute);
                
                return in_ease.Execute(input);
            }
            else if (out_ease != null)
            {
                return EaseOperations.Inverse(input, out_ease.Execute);
            }

            return 0.0f;
        }
    }
}