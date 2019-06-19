using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public delegate T MultiOperation<T>();
    public delegate T MultiOperation<T, P1>(P1 p1);
    public delegate T MultiOperation<T, P1, P2>(P1 p1, P2 p2);
    public delegate T MultiOperation<T, P1, P2, P3>(P1 p1, P2 p2, P3 p3);
    public delegate T MultiOperation<T, P1, P2, P3, P4>(P1 p1, P2 p2, P3 p3, P4 p4);
    public delegate T MultiOperation<T, P1, P2, P3, P4, P5>(P1 p1, P2 p2, P3 p3, P4 p4, P5 p5);
    public delegate T MultiOperation<T, P1, P2, P3, P4, P5, P6>(P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6);
    public delegate T MultiOperation<T, P1, P2, P3, P4, P5, P6, P7>(P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7);
    public delegate T MultiOperation<T, P1, P2, P3, P4, P5, P6, P7, P8>(P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7, P8 p8);
    public delegate T MultiOperation<T, P1, P2, P3, P4, P5, P6, P7, P8, P9>(P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7, P8 p8, P9 p9);
    public delegate T MultiOperation<T, P1, P2, P3, P4, P5, P6, P7, P8, P9, P10>(P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7, P8 p8, P9 p9, P10 p10);
}