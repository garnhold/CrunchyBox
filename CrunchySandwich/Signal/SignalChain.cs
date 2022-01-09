using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Crunchy.Dough;

    public class SignalChain
    {
        [SerializeFieldEX][PolymorphicField] private List<Signal> signals;

        public SignalChain(IEnumerable<Signal> s)
        {
            signals = s.ToList();
        }
        public SignalChain(Signal[] s) : this((IEnumerable<Signal>)s) { }
        public SignalChain() : this(null) { }

        public float Execute(float input)
        {
            return signals.Apply(input, (i, s) => s.Execute(i));
        }
    }
}