using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    public class EditDistinctionAttribute : Attribute
    {
    }
}