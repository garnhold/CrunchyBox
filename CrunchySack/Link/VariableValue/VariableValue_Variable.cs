using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class VariableValue_Variable : VariableValue
    {
        private Variable variable;

        protected override void Push(object representation, object value)
        {
            variable.SetContents(representation, value);
        }

        public VariableValue_Variable(Variable var, object r, object v) : base(r, v)
        {
            variable = var;
        }
    }
}