using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class RouletteExtensions_Add
    {
        static public void Add<T>(this Roulette<T> item, KeyValuePair<T, float> pair)
        {
            item.Add(pair.Key, pair.Value);
        }

        static public void Add<T>(this Roulette<T> item, IEnumerable<KeyValuePair<T, float>> to_add)
        {
            to_add.Process(b => item.Add(b));
        }
        static public void Add<T>(this Roulette<T> item, params KeyValuePair<T, float>[] to_add)
        {
            item.Add((IEnumerable<KeyValuePair<T, float>>)to_add);
        }
    }
}