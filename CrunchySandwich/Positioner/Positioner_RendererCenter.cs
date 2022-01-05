using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Salt;
    using Noodle;
    using Recipe;
    
    public class Positioner_RendererCenter : Positioner
    {
        protected override Vector3 CalculatePosition(GameObject target)
        {
            return target.GetSpacarRendererBounds().center;
        }
    }
}