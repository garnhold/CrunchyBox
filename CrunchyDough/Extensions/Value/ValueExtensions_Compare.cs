using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class ValueExtensions_Compare
    {
        static public bool Conforms<T>(this T item, ref T output)
        {
            if (output == null)
                output = item;

            if (output.EqualsEX(item))
                return true;

            return false;
        }

        static public T Transition<T>(this T item, T new_value, Process<T> start_process, Process<T> end_process)
        {
            if (new_value.NotEqualsEX(item))
            {
                item.IfNotNull(end_process);
                new_value.IfNotNull(start_process);
            }

            return new_value;
        }
        static public T TransitionStart<T>(this T item, T new_value, Process<T> start_process)
        {
            return item.Transition<T>(new_value, start_process, i => { });
        }
        static public T TransitionEnd<T>(this T item, T new_value, Process<T> end_process)
        {
            return item.Transition<T>(new_value, i => { }, end_process);
        }

        static public bool IsNull<T>(this T item)
        {
            if (item.EqualsEX(null))
                return true;

            return false;
        }

        static public bool IsNotNull<T>(this T item)
        {
            if (item.IsNull() == false)
                return true;

            return false;
        }
    }
}