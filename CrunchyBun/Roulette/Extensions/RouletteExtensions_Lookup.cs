using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyBun
{
    static public class RouletteExtensions_Lookup
    {
        static public T Lookup<T>(this Roulette<T> item, float value)
        {
            T output;

            item.TryLookup(value, out output);
            return output;
        }

        static public T Lookup<T>(this Roulette<T> item, float value, T default_value)
        {
            T output;

            if (item.TryLookup(value, out output))
                return output;

            return default_value;
        }
    }
}