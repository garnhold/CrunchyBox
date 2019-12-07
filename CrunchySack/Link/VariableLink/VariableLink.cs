using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class VariableLink
    {
        private VariableNode dominate_node;
        private VariableNode submissive_node;

        private VariableLinkState state;

        private bool PropagateDominate(bool allow_backflow = true)
        {
            if (submissive_node.PushValue(dominate_node.GetValue()))
            {
                state = VariableLinkState.Equal;
                return true;
            }

            if (allow_backflow)
                return PropagateSubmissive(false);

            return false;
        }

        private bool PropagateSubmissive(bool allow_backflow = true)
        {
            if (dominate_node.PushValue(submissive_node.GetValue()))
            {
                state = VariableLinkState.Equal;
                return true;
            }

            if (allow_backflow)
                return PropagateDominate(false);

            return false;
        }

        public VariableLink(VariableNode d, VariableNode s)
        {
            dominate_node = d;
            submissive_node = s;

            state = VariableLinkState.DominateActive;
        }

        public void Update()
        {
            bool did_dominate_change = dominate_node.UpdateState();
            bool did_submissive_change = submissive_node.UpdateState();

            if (did_dominate_change)
                state = VariableLinkState.DominateActive;
            else if (did_submissive_change)
                state = VariableLinkState.SubmissiveActive;

            switch (state)
            {
                case VariableLinkState.DominateActive: PropagateDominate(); break;
                case VariableLinkState.SubmissiveActive: PropagateSubmissive(); break;
            }
        }
    }
}