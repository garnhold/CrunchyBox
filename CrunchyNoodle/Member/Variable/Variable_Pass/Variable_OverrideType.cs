using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Variable_OverrideType : Variable_Pass
    {
        public Variable_OverrideType(Type v, Variable i) : base(i, i.GetDeclaringType(), v) { }
    }
}