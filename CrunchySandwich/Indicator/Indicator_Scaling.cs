using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    public class Indicator_Scaling : Indicator
    {
        public override void Initialize(Vector3 position, float strength)
        {
            this.SetSpacarPosition(position);
            this.SetSpacarScale(strength);
        }
    }
}