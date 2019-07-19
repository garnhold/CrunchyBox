using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumeratorExtensions_Tandem
    {
        static public bool MoveTandemNextStrict<T, J>(this IEnumerator<T> item, IEnumerator<J> other, out T value1, out J value2)
        {
            if (item.MoveNext())
            {
                value1 = item.Current;

                if (other.MoveNext())
                {
                    value2 = other.Current;
                    return true;
                }
            }

            value1 = default(T);
            value2 = default(J);
            return false;
        }

        static public bool MoveTandemNextPermissive<T, J>(this IEnumerator<T> item, IEnumerator<J> other, out T value1, out J value2)
        {
            bool did_move = false;

            try
            {
                if (item.MoveNext())
                {
                    value1 = item.Current;
                    did_move = true;
                }
                else
                {
                    value1 = default(T);
                }
            }
            catch (InvalidOperationException)
            {
                value1 = default(T);
            }

            try
            {
                if (other.MoveNext())
                {
                    value2 = other.Current;
                    did_move = true;
                }
                else
                {
                    value2 = default(J);
                }
            }
            catch (InvalidOperationException)
            {
                value2 = default(J);
            }

            return did_move;
        }
    }
}