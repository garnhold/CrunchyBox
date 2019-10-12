using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    public abstract class Variable_Pass : Variable
    {
        private Variable internal_variable;

        protected override bool SetContentsInternal(object target, object value) { return internal_variable.SetContents(target, value); }
        protected override object GetContentsInternal(object target) { return internal_variable.GetContents(target); }

        protected override string GetVariableNameInternal() { return internal_variable.GetVariableName(); }
        protected override IEnumerable<Attribute> GetAllCustomAttributesInternal(bool inherit) { return internal_variable.GetAllCustomAttributes(inherit); }

        public Variable_Pass(Variable i, Type d, Type v) : base(d, v)
        {
            internal_variable = i;
        }
    }
}