using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class VariableLink_Simple_Direct : VariableLink_Simple
    {
        protected override object GetDominateValue(VariableNode dominate_node)
        {
            return dominate_node.GetValue();
        }

        protected override object GetSubmissiveValue(VariableNode submissive_node)
        {
            return submissive_node.GetValue();
        }

        public VariableLink_Simple_Direct(VariableNode d, VariableNode s) : base(d, s) { }
    }
}