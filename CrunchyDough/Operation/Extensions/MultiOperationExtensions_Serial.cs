using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class MultiOperationExtensions_Serial
    {
        static public T InvokeAllSerial<T>(this MultiOperation<T, T> item, T input)
        {
            if (item != null)
            {
                return item.GetInvocationList()
                    .Convert<MultiOperation<T, T>>()
                    .Apply(input, (i, o) => o(i));
            }

            return input;
        }

        static public T InvokeAllSerial<T, P2>(this MultiOperation<T, T> item, T input, P2 p2)
        {
            if (item != null)
            {
                return item.GetInvocationList()
                    .Convert<MultiOperation<T, T, P2>>()
                    .Apply(input, (i, o) => o(i, p2));
            }

            return input;
        }

        static public T InvokeAllSerial<T, P2, P3>(this MultiOperation<T, T> item, T input, P2 p2, P3 p3)
        {
            if (item != null)
            {
                return item.GetInvocationList()
                    .Convert<MultiOperation<T, T, P2, P3>>()
                    .Apply(input, (i, o) => o(i, p2, p3));
            }

            return input;
        }

        static public T InvokeAllSerial<T, P2, P3, P4>(this MultiOperation<T, T> item, T input, P2 p2, P3 p3, P4 p4)
        {
            if (item != null)
            {
                return item.GetInvocationList()
                    .Convert<MultiOperation<T, T, P2, P3, P4>>()
                    .Apply(input, (i, o) => o(i, p2, p3, p4));
            }

            return input;
        }

        static public T InvokeAllSerial<T, P2, P3, P4, P5>(this MultiOperation<T, T> item, T input, P2 p2, P3 p3, P4 p4, P5 p5)
        {
            if (item != null)
            {
                return item.GetInvocationList()
                    .Convert<MultiOperation<T, T, P2, P3, P4, P5>>()
                    .Apply(input, (i, o) => o(i, p2, p3, p4, p5));
            }

            return input;
        }

        static public T InvokeAllSerial<T, P2, P3, P4, P5, P6>(this MultiOperation<T, T> item, T input, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6)
        {
            if (item != null)
            {
                return item.GetInvocationList()
                    .Convert<MultiOperation<T, T, P2, P3, P4, P5, P6>>()
                    .Apply(input, (i, o) => o(i, p2, p3, p4, p5, p6));
            }

            return input;
        }

        static public T InvokeAllSerial<T, P2, P3, P4, P5, P6, P7>(this MultiOperation<T, T> item, T input, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7)
        {
            if (item != null)
            {
                return item.GetInvocationList()
                    .Convert<MultiOperation<T, T, P2, P3, P4, P5, P6, P7>>()
                    .Apply(input, (i, o) => o(i, p2, p3, p4, p5, p6, p7));
            }

            return input;
        }

        static public T InvokeAllSerial<T, P2, P3, P4, P5, P6, P7, P8>(this MultiOperation<T, T> item, T input, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7, P8 p8)
        {
            if (item != null)
            {
                return item.GetInvocationList()
                    .Convert<MultiOperation<T, T, P2, P3, P4, P5, P6, P7, P8>>()
                    .Apply(input, (i, o) => o(i, p2, p3, p4, p5, p6, p7, p8));
            }

            return input;
        }

        static public T InvokeAllSerial<T, P2, P3, P4, P5, P6, P7, P8, P9>(this MultiOperation<T, T> item, T input, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7, P8 p8, P9 p9)
        {
            if (item != null)
            {
                return item.GetInvocationList()
                    .Convert<MultiOperation<T, T, P2, P3, P4, P5, P6, P7, P8, P9>>()
                    .Apply(input, (i, o) => o(i, p2, p3, p4, p5, p6, p7, p8, p9));
            }

            return input;
        }

        static public T InvokeAllSerial<T, P2, P3, P4, P5, P6, P7, P8, P9, P10>(this MultiOperation<T, T> item, T input, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7, P8 p8, P9 p9, P10 p10)
        {
            if (item != null)
            {
                return item.GetInvocationList()
                    .Convert<MultiOperation<T, T, P2, P3, P4, P5, P6, P7, P8, P9, P10>>()
                    .Apply(input, (i, o) => o(i, p2, p3, p4, p5, p6, p7, p8, p9, p10));
            }

            return input;
        }
    }
}