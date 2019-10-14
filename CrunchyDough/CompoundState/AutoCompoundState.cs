using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class AutoCompoundState<P1, P2, P3, P4> : AutoCompoundState
    {
        private Operation<P1> get_p1;
        private Operation<P2> get_p2;
        private Operation<P3> get_p3;
        private Operation<P4> get_p4;

        private CompoundState<P1, P2, P3, P4> state;

        public AutoCompoundState(Operation<P1> p1, Operation<P2> p2, Operation<P3> p3, Operation<P4> p4)
        {
            get_p1 = p1;
            get_p2 = p2;
            get_p3 = p3;
            get_p4 = p4;

            state = new CompoundState<P1, P2, P3, P4>();
        }

        public override bool UpdateState()
        {
            return state.UpdateState(get_p1(), get_p2(), get_p3(), get_p4());
        }

        public override void DirtyState()
        {
            state.DirtyState();
        }
    }

    public class AutoCompoundState<P1, P2, P3> : AutoCompoundState
    {
        private Operation<P1> get_p1;
        private Operation<P2> get_p2;
        private Operation<P3> get_p3;

        private CompoundState<P1, P2, P3> state;

        public AutoCompoundState(Operation<P1> p1, Operation<P2> p2, Operation<P3> p3)
        {
            get_p1 = p1;
            get_p2 = p2;
            get_p3 = p3;

            state = new CompoundState<P1, P2, P3>();
        }

        public override bool UpdateState()
        {
            return state.UpdateState(get_p1(), get_p2(), get_p3());
        }

        public override void DirtyState()
        {
            state.DirtyState();
        }
    }

    public class AutoCompoundState<P1, P2> : AutoCompoundState
    {
        private Operation<P1> get_p1;
        private Operation<P2> get_p2;

        private CompoundState<P1, P2> state;

        public AutoCompoundState(Operation<P1> p1, Operation<P2> p2)
        {
            get_p1 = p1;
            get_p2 = p2;

            state = new CompoundState<P1, P2>();
        }

        public override bool UpdateState()
        {
            return state.UpdateState(get_p1(), get_p2());
        }

        public override void DirtyState()
        {
            state.DirtyState();
        }
    }

    public abstract class AutoCompoundState
    {
        static public AutoCompoundState<P1, P2, P3, P4> New<P1, P2, P3, P4>(Operation<P1> p1, Operation<P2> p2, Operation<P3> p3, Operation<P4> p4)
        {
            return new AutoCompoundState<P1, P2, P3, P4>(p1, p2, p3, p4);
        }

        static public AutoCompoundState<P1, P2, P3> New<P1, P2, P3>(Operation<P1> p1, Operation<P2> p2, Operation<P3> p3)
        {
            return new AutoCompoundState<P1, P2, P3>(p1, p2, p3);
        }

        static public AutoCompoundState<P1, P2> New<P1, P2>(Operation<P1> p1, Operation<P2> p2)
        {
            return new AutoCompoundState<P1, P2>(p1, p2);
        }

        public abstract bool UpdateState();
        public abstract void DirtyState();
    }
}
