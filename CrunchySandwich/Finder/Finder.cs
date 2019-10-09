using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

using UnityEngine;

namespace CrunchySandwich
{
    static public partial class Finder
    {
        static public IEnumerable<T> Find<T>() where T : Component
        {
            return GameObject.FindObjectsOfType<T>();
        }

        static public T FindFirst<T>() where T : Component
        {
            return GameObject.FindObjectOfType<T>();
        }

        static public T FindPlanarClosest<T>(Vector2 position) where T : Component
        {
            return Find<T>().FindLowestRated(t => t.GetPlanarSquaredDistanceBetween(position));
        }
    }
}