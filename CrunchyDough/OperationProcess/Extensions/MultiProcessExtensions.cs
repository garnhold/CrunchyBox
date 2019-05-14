using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class MultiProcessExtensions
    {
        static public void InvokeAll(this MultiProcess item)
        {
            if (item != null)
                item();
        }

        static public void InvokeAll<P1>(this MultiProcess<P1> item, P1 p1)
        {
            if (item != null)
                item(p1);
        }

        static public void InvokeAll<P1, P2>(this MultiProcess<P1, P2> item, P1 p1, P2 p2)
        {
            if (item != null)
                item(p1, p2);
        }

        static public void InvokeAll<P1, P2, P3>(this MultiProcess<P1, P2, P3> item, P1 p1, P2 p2, P3 p3)
        {
            if (item != null)
                item(p1, p2, p3);
        }

        static public void InvokeAll<P1, P2, P3, P4>(this MultiProcess<P1, P2, P3, P4> item, P1 p1, P2 p2, P3 p3, P4 p4)
        {
            if (item != null)
                item(p1, p2, p3, p4);
        }

        static public void InvokeAll<P1, P2, P3, P4, P5>(this MultiProcess<P1, P2, P3, P4, P5> item, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5)
        {
            if (item != null)
                item(p1, p2, p3, p4, p5);
        }

        static public void InvokeAll<P1, P2, P3, P4, P5, P6>(this MultiProcess<P1, P2, P3, P4, P5, P6> item, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6)
        {
            if (item != null)
                item(p1, p2, p3, p4, p5, p6);
        }

        static public void InvokeAll<P1, P2, P3, P4, P5, P6, P7>(this MultiProcess<P1, P2, P3, P4, P5, P6, P7> item, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7)
        {
            if (item != null)
                item(p1, p2, p3, p4, p5, p6, p7);
        }

        static public void InvokeAll<P1, P2, P3, P4, P5, P6, P7, P8>(this MultiProcess<P1, P2, P3, P4, P5, P6, P7, P8> item, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7, P8 p8)
        {
            if (item != null)
                item(p1, p2, p3, p4, p5, p6, p7, p8);
        }

        static public void InvokeAll<P1, P2, P3, P4, P5, P6, P7, P8, P9>(this MultiProcess<P1, P2, P3, P4, P5, P6, P7, P8, P9> item, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7, P8 p8, P9 p9)
        {
            if (item != null)
                item(p1, p2, p3, p4, p5, p6, p7, p8, p9);
        }

        static public void InvokeAll<P1, P2, P3, P4, P5, P6, P7, P8, P9, P10>(this MultiProcess<P1, P2, P3, P4, P5, P6, P7, P8, P9, P10> item, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7, P8 p8, P9 p9, P10 p10)
        {
            if (item != null)
                item(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);
        }
    }
}