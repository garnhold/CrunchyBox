using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Texture2DExtensions_Stamp
    {
        static public Stamp<T> CreateStamp<T>(this Texture2D item, Operation<T, int, int> operation)
        {
            return item.CreateGrid<T>(operation).CreateStamp<T>();
        }

        static public Stamp<T> CreateStamp<T>(this Texture2D item, Operation<T, Color> operation)
        {
            return item.CreateGrid<T>(operation).CreateStamp<T>();
        }
    }
}