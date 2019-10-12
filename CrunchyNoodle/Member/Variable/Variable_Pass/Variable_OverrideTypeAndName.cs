using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Variable_OverrideTypeAndName : Variable_Pass
    {
        private string name;

        protected override string GetVariableNameInternal()
        {
            return name;
        }

        public Variable_OverrideTypeAndName(Type v, string n, Variable i) : base(i, i.GetDeclaringType(), v)
        {
            name = n;
        }
    }
}