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
    
    [AttributeUsage(AttributeTargets.Class)]
    public class SaveStateExplicitTypeAttribute : Attribute
    {
    }
}