using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class SignalExtensions_IEnumerable_Execute
    {
        static public float Execute(this IEnumerable<Signal> item, float input)
        {
            return item.Apply(input, (i, s) => s.Execute(i));
        }
    }
}