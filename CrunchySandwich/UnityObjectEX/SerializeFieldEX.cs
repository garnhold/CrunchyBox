using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

//TODO: Make it so that a warning is given if this is on a field that can't serialize because missing MonoBehaviourEX etc.

namespace Crunchy.Sandwich
{
    using Dough;
    using Salt;
    using Noodle;
    using Recipe;
    
    [AttributeUsage(AttributeTargets.Field)]
    public class SerializeFieldEX : Attribute
    {
    }
}