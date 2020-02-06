using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public abstract class VariableLink
    {
        private VariableLinkState state;

        protected abstract void UpdateInternal();

        protected abstract bool PushDominateToSubmissive();
        protected abstract bool PushSubmissiveToDominate();

        private bool PropagateDominate(bool allow_backflow = true)
        {
            if (PushDominateToSubmissive())
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
            if (PushSubmissiveToDominate())
            {
                state = VariableLinkState.Equal;
                return true;
            }

            if (allow_backflow)
                return PropagateDominate(false);

            return false;
        }

        protected void PushState(VariableLinkState new_state)
        {
            state = new_state;
        }

        public VariableLink()
        {
            state = VariableLinkState.DominateActive;
        }

        public void Update()
        {
            UpdateInternal();

            switch (state)
            {
                case VariableLinkState.DominateActive: PropagateDominate(); break;
                case VariableLinkState.SubmissiveActive: PropagateSubmissive(); break;
            }
        }
    }
}