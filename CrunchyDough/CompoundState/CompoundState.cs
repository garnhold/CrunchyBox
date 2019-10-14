using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class CompoundState<P1, P2, P3, P4>
    {
        private P1 p1;
        private P2 p2;
        private P3 p3;
        private P4 p4;

        public bool UpdateState(P1 np1, P2 np2, P3 np3, P4 np4)
        {
            if (p1.NotEqualsEX(np1) || p2.NotEqualsEX(np2) || p3.NotEqualsEX(np3) || p4.NotEqualsEX(np4))
            {
                p1 = np1;
                p2 = np2;
                p3 = np3;
                p4 = np4;

                return true;
            }

            return false;
        }

        public void DirtyState()
        {
            p1 = default(P1);
            p2 = default(P2);
            p3 = default(P3);
            p4 = default(P4);
        }
    }

    public class CompoundState<P1, P2, P3>
    {
        private P1 p1;
        private P2 p2;
        private P3 p3;

        public bool UpdateState(P1 np1, P2 np2, P3 np3)
        {
            if (p1.NotEqualsEX(np1) || p2.NotEqualsEX(np2) || p3.NotEqualsEX(np3))
            {
                p1 = np1;
                p2 = np2;
                p3 = np3;

                return true;
            }

            return false;
        }

        public void DirtyState()
        {
            p1 = default(P1);
            p2 = default(P2);
            p3 = default(P3);
        }
    }

    public class CompoundState<P1, P2>
    {
        private P1 p1;
        private P2 p2;

        public bool UpdateState(P1 np1, P2 np2)
        {
            if (p1.NotEqualsEX(np1) || p2.NotEqualsEX(np2))
            {
                p1 = np1;
                p2 = np2;

                return true;
            }

            return false;
        }

        public void DirtyState()
        {
            p1 = default(P1);
            p2 = default(P2);
        }
    }
}
