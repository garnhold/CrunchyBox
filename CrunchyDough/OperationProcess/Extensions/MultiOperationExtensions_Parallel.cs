using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class MultiOperationExtensions_Parallel
    {
        static public IEnumerable<T> InvokeAllParallel<T>(this MultiOperation<T> item)
        {
            if (item != null)
            {
                return item.GetInvocationList()
                    .Convert<MultiOperation<T>>()
                    .Convert(o => o());
            }

            return Empty.IEnumerable<T>();
        }

        static public IEnumerable<T> InvokeAllParallel<T, P1>(this MultiOperation<T, P1> item, P1 p1)
        {
            if (item != null)
            {
                return item.GetInvocationList()
                    .Convert<MultiOperation<T, P1>>()
                    .Convert(o => o(p1));
            }

            return Empty.IEnumerable<T>();
        }

        static public IEnumerable<T> InvokeAllParallel<T, P1, P2>(this MultiOperation<T, P1> item, P1 p1, P2 p2)
        {
            if (item != null)
            {
                return item.GetInvocationList()
                    .Convert<MultiOperation<T, P1, P2>>()
                    .Convert(o => o(p1, p2));
            }

            return Empty.IEnumerable<T>();
        }

        static public IEnumerable<T> InvokeAllParallel<T, P1, P2, P3>(this MultiOperation<T, P1> item, P1 p1, P2 p2, P3 p3)
        {
            if (item != null)
            {
                return item.GetInvocationList()
                    .Convert<MultiOperation<T, P1, P2, P3>>()
                    .Convert(o => o(p1, p2, p3));
            }

            return Empty.IEnumerable<T>();
        }

        static public IEnumerable<T> InvokeAllParallel<T, P1, P2, P3, P4>(this MultiOperation<T, P1> item, P1 p1, P2 p2, P3 p3, P4 p4)
        {
            if (item != null)
            {
                return item.GetInvocationList()
                    .Convert<MultiOperation<T, P1, P2, P3, P4>>()
                    .Convert(o => o(p1, p2, p3, p4));
            }

            return Empty.IEnumerable<T>();
        }

        static public IEnumerable<T> InvokeAllParallel<T, P1, P2, P3, P4, P5>(this MultiOperation<T, P1> item, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5)
        {
            if (item != null)
            {
                return item.GetInvocationList()
                    .Convert<MultiOperation<T, P1, P2, P3, P4, P5>>()
                    .Convert(o => o(p1, p2, p3, p4, p5));
            }

            return Empty.IEnumerable<T>();
        }

        static public IEnumerable<T> InvokeAllParallel<T, P1, P2, P3, P4, P5, P6>(this MultiOperation<T, P1> item, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6)
        {
            if (item != null)
            {
                return item.GetInvocationList()
                    .Convert<MultiOperation<T, P1, P2, P3, P4, P5, P6>>()
                    .Convert(o => o(p1, p2, p3, p4, p5, p6));
            }

            return Empty.IEnumerable<T>();
        }

        static public IEnumerable<T> InvokeAllParallel<T, P1, P2, P3, P4, P5, P6, P7>(this MultiOperation<T, P1> item, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7)
        {
            if (item != null)
            {
                return item.GetInvocationList()
                    .Convert<MultiOperation<T, P1, P2, P3, P4, P5, P6, P7>>()
                    .Convert(o => o(p1, p2, p3, p4, p5, p6, p7));
            }

            return Empty.IEnumerable<T>();
        }

        static public IEnumerable<T> InvokeAllParallel<T, P1, P2, P3, P4, P5, P6, P7, P8>(this MultiOperation<T, P1> item, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7, P8 p8)
        {
            if (item != null)
            {
                return item.GetInvocationList()
                    .Convert<MultiOperation<T, P1, P2, P3, P4, P5, P6, P7, P8>>()
                    .Convert(o => o(p1, p2, p3, p4, p5, p6, p7, p8));
            }

            return Empty.IEnumerable<T>();
        }

        static public IEnumerable<T> InvokeAllParallel<T, P1, P2, P3, P4, P5, P6, P7, P8, P9>(this MultiOperation<T, P1> item, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7, P8 p8, P9 p9)
        {
            if (item != null)
            {
                return item.GetInvocationList()
                    .Convert<MultiOperation<T, P1, P2, P3, P4, P5, P6, P7, P8, P9>>()
                    .Convert(o => o(p1, p2, p3, p4, p5, p6, p7, p8, p9));
            }

            return Empty.IEnumerable<T>();
        }

        static public IEnumerable<T> InvokeAllParallel<T, P1, P2, P3, P4, P5, P6, P7, P8, P9, P10>(this MultiOperation<T, P1> item, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7, P8 p8, P9 p9, P10 p10)
        {
            if (item != null)
            {
                return item.GetInvocationList()
                    .Convert<MultiOperation<T, P1, P2, P3, P4, P5, P6, P7, P8, P9, P10>>()
                    .Convert(o => o(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10));
            }

            return Empty.IEnumerable<T>();
        }
    }
}