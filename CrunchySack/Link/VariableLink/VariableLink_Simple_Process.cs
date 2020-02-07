using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;

    public class VariableLink_Simple_Process : VariableLink_Simple
    {
        private Operation<object, object> dominate_to_common;
        private Operation<object, object> submissive_to_common;

        protected override object GetDominateValue(VariableNode dominate_node)
        {
            return dominate_to_common(dominate_node.GetValue());
        }

        protected override object GetSubmissiveValue(VariableNode submissive_node)
        {
            return submissive_to_common(submissive_node.GetValue());
        }

        public VariableLink_Simple_Process(VariableNode d, VariableNode s, Operation<object, object> dtc, Operation<object, object> stc) : base(d, s)
        {
            dominate_to_common = dtc;
            submissive_to_common = stc;
        }
    }
}