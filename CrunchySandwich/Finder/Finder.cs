using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

using UnityEngine;

namespace CrunchySandwich
{
    static public partial class Finder
    {
        static public T FindPlanarClosest<T>(Vector2 position) where T : Component
        {
            return GameObject.FindObjectsOfType<T>().FindLowestRated(t => t.GetPlanarSquaredDistanceBetween(position));
        }
    }
}