using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public abstract class VariableLink_Simple : VariableLink
    {
        private VariableNode dominate_node;
        private VariableNode submissive_node;

        protected abstract object GetDominateValue(VariableNode dominate_node);
        protected abstract object GetSubmissiveValue(VariableNode submissive_node);

        protected override void UpdateInternal()
        {
            bool did_dominate_change = dominate_node.UpdateState();
            bool did_submissive_change = submissive_node.UpdateState();

            if (did_dominate_change)
                PushState(VariableLinkState.DominateActive);
            else if (did_submissive_change)
                PushState(VariableLinkState.SubmissiveActive);
        }

        protected override bool PushDominateToSubmissive()
        {
            return submissive_node.PushValue(
                GetDominateValue(dominate_node)
            );
        }

        protected override bool PushSubmissiveToDominate()
        {
            return dominate_node.PushValue(
                GetSubmissiveValue(submissive_node)
            );
        }

        public VariableLink_Simple(VariableNode d, VariableNode s)
        {
            dominate_node = d;
            submissive_node = s;
        }
    }
}