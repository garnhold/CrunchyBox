using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Texture2DExtensions_Grid
    {
        static public Grid<T> CreateGrid<T>(this Texture2D item, Operation<T, int, int> operation)
        {
            return new Grid<T>(item.width, item.height, operation);
        }

        static public Grid<T> CreateGrid<T>(this Texture2D item, Operation<T, Color> operation)
        {
            return new Grid<T>(item.width, item.height, item.GetPixels().Convert(operation));
        }
    }
}