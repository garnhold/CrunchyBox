using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;

    public class VariableLink_Simple_EffigySurrogate : VariableLink_Simple
    {
        private EffigySource_Collection effigy;

        protected override object GetDominateValue(VariableNode dominate_node)
        {
            return effigy.GetValues().FindIndexOf(dominate_node.GetValue());
        }

        protected override object GetSubmissiveValue(VariableNode submissive_node)
        {
            return effigy.GetValues().Get(submissive_node.GetValue().ConvertEX<int>());
        }

        public VariableLink_Simple_EffigySurrogate(VariableNode d, VariableNode s, EffigySource_Collection e) : base(d, s)
        {
            effigy = e;
        }
    }
}