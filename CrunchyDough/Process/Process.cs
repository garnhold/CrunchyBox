using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public delegate void Process();
    public delegate void Process<P1>(P1 p1);
    public delegate void Process<P1, P2>(P1 p1, P2 p2);
    public delegate void Process<P1, P2, P3>(P1 p1, P2 p2, P3 p3);
    public delegate void Process<P1, P2, P3, P4>(P1 p1, P2 p2, P3 p3, P4 p4);
    public delegate void Process<P1, P2, P3, P4, P5>(P1 p1, P2 p2, P3 p3, P4 p4, P5 p5);
    public delegate void Process<P1, P2, P3, P4, P5, P6>(P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6);
    public delegate void Process<P1, P2, P3, P4, P5, P6, P7>(P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7);
    public delegate void Process<P1, P2, P3, P4, P5, P6, P7, P8>(P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7, P8 p8);
    public delegate void Process<P1, P2, P3, P4, P5, P6, P7, P8, P9>(P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7, P8 p8, P9 p9);
    public delegate void Process<P1, P2, P3, P4, P5, P6, P7, P8, P9, P10>(P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7, P8 p8, P9 p9, P10 p10);

    public delegate bool TryProcess();
    public delegate bool TryProcess<P1>(P1 p1);
    public delegate bool TryProcess<P1, P2>(P1 p1, P2 p2);
    public delegate bool TryProcess<P1, P2, P3>(P1 p1, P2 p2, P3 p3);
    public delegate bool TryProcess<P1, P2, P3, P4>(P1 p1, P2 p2, P3 p3, P4 p4);
    public delegate void TryProcess<P1, P2, P3, P4, P5>(P1 p1, P2 p2, P3 p3, P4 p4, P5 p5);
    public delegate void TryProcess<P1, P2, P3, P4, P5, P6>(P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6);
    public delegate void TryProcess<P1, P2, P3, P4, P5, P6, P7>(P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7);
    public delegate void TryProcess<P1, P2, P3, P4, P5, P6, P7, P8>(P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7, P8 p8);
    public delegate void TryProcess<P1, P2, P3, P4, P5, P6, P7, P8, P9>(P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7, P8 p8, P9 p9);
    public delegate void TryProcess<P1, P2, P3, P4, P5, P6, P7, P8, P9, P10>(P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7, P8 p8, P9 p9, P10 p10);

    public delegate AttemptResult AttemptProcess();
    public delegate AttemptResult AttemptProcess<P1>(P1 p1);
    public delegate AttemptResult AttemptProcess<P1, P2>(P1 p1, P2 p2);
    public delegate AttemptResult AttemptProcess<P1, P2, P3>(P1 p1, P2 p2, P3 p3);
    public delegate AttemptResult AttemptProcess<P1, P2, P3, P4>(P1 p1, P2 p2, P3 p3, P4 p4);
    public delegate AttemptResult AttemptProcess<P1, P2, P3, P4, P5>(P1 p1, P2 p2, P3 p3, P4 p4, P5 p5);
    public delegate AttemptResult AttemptProcess<P1, P2, P3, P4, P5, P6>(P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6);
    public delegate AttemptResult AttemptProcess<P1, P2, P3, P4, P5, P6, P7>(P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7);
    public delegate AttemptResult AttemptProcess<P1, P2, P3, P4, P5, P6, P7, P8>(P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7, P8 p8);
    public delegate AttemptResult AttemptProcess<P1, P2, P3, P4, P5, P6, P7, P8, P9>(P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7, P8 p8, P9 p9);
    public delegate AttemptResult AttemptProcess<P1, P2, P3, P4, P5, P6, P7, P8, P9, P10>(P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7, P8 p8, P9 p9, P10 p10);
}