using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class PaletteExtensions_Add
    {
        static public void AddRange<T>(this Palette<T> item, IEnumerable<T> to_add)
        {
            to_add.Process(i => item.Add(i));
        }
    }
}