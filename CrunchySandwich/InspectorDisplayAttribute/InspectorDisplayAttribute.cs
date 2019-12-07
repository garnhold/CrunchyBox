using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Method)]
    public class InspectorDisplayAttribute : Attribute
    {
    }
}