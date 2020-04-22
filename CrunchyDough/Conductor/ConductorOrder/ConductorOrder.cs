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

        protected virtual void CancelFulfill() { }
        protected virtual void FinishFulfill() { }
        protected virtual void DoneFulfill() { }

        protected abstract bool UpdateFulfill();

        private void OnDone(ConductorOrderState s)
        {
            switch (s)
            {
                case ConductorOrderState.Uninitialized:
                    CancelFulfill();
                    DoneFulfill();
                    state = ConductorOrderState.Uninitialized;
                    return;

                case ConductorOrderState.Done:
                    FinishFulfill();
                    DoneFulfill();
                    state = ConductorOrderState.Done;
                    return;
            }

            throw new UnaccountedBranchException("s", s);
        }

        public ConductorOrder()
        {
            state = ConductorOrderState.Uninitialized;
        }

        public void Reset()
        {
            switch (state)
            {
                case ConductorOrderState.Uninitialized:
                    return;

                case ConductorOrderState.Initialized:
                    OnDone(ConductorOrderState.Uninitialized);
                    return;

                case ConductorOrderState.Started:
                    OnDone(ConductorOrderState.Uninitialized);
                    return;

                case ConductorOrderState.Done:
                    state = ConductorOrderState.Uninitialized;
                    return;
            }

            throw new UnaccountedBranchException("state", state);
        }

        public void Prime()
        {
            switch (state)
            {
                case ConductorOrderState.Uninitialized:
                    state = ConductorOrderState.Done;
                    return;

                case ConductorOrderState.Initialized:
                    OnDone(ConductorOrderState.Done);
                    return;

                case ConductorOrderState.Started:
                    OnDone(ConductorOrderState.Done);
                    return;

                case ConductorOrderState.Done:
                    return;
            }

            throw new UnaccountedBranchException("state", state);
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

                    OnDone(ConductorOrderState.Done);
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
                    OnDone(ConductorOrderState.Done);
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
