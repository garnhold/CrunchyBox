using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public abstract class ConductorOrder
    {
        private ConductorOrderState state;

        protected virtual bool InitializeFulfill() { return true; }
        protected virtual void StartFulfill() { }
        protected virtual void PauseFulfill() { }

        protected abstract bool UpdateFulfill();

        public ConductorOrder()
        {
            state = ConductorOrderState.Uninitialized;
        }

        public void Reset()
        {
            state = ConductorOrderState.Uninitialized;
        }

        public void Prime()
        {
            state = ConductorOrderState.Done;
        }

        public bool ResumeFulfill()
        {
            switch (state)
            {
                case ConductorOrderState.Uninitialized:
                    if (InitializeFulfill())
                    {
                        StartFulfill();
                        state = ConductorOrderState.Started;
                        return true;
                    }

                    state = ConductorOrderState.Done;
                    return false;

                case ConductorOrderState.Initialized:
                    StartFulfill();
                    state = ConductorOrderState.Started;
                    return true;

                case ConductorOrderState.Started: return true;
                case ConductorOrderState.Done: return false;
            }

            throw new UnaccountedBranchException("state", state);
        }

        public void SuspendFulfill()
        {
            switch (state)
            {
                case ConductorOrderState.Uninitialized:
                    return;

                case ConductorOrderState.Initialized:
                    return;

                case ConductorOrderState.Started:
                    PauseFulfill();
                    state = ConductorOrderState.Initialized;
                    return;

                case ConductorOrderState.Done:
                    return;
            }

            throw new UnaccountedBranchException("state", state);
        }

        public bool ContinueFulfill()
        {
            if(ResumeFulfill())
            {
                if (UpdateFulfill())
                    state = ConductorOrderState.Done;
            }

            return IsDone();
        }

        public bool IsDone()
        {
            if (state == ConductorOrderState.Done)
                return true;

            return false;
        }
    }
}
