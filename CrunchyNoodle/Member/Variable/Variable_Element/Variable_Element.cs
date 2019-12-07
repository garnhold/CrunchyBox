using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    public class Variable_Element : Variable
    {
        private Variable variable;
        private int index;

        protected override bool SetContentsInternal(object target, object value)
        {
            return variable.GetContents<IEnumerable>(target).InspectSet(index, value);
        }

        protected override object GetContentsInternal(object target)
        {
            return variable.GetContents<IEnumerable>(target).InspectGet(index);
        }

        protected override string GetVariableNameInternal()
        {
            return variable.GetVariableName() + "[" + index + "]";
        }

        protected override IEnumerable<Attribute> GetAllCustomAttributesInternal(bool inherit)
        {
            return variable.GetAllCustomAttributes(inherit);
        }

        public Variable_Element(Variable v, int i) : base(v.GetDeclaringType(), v.GetVariableType().GetIEnumerableType())
        {
            variable = v;
            index = i;
        }
    }
}