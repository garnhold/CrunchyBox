using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class PlaneExtensions_PlaneSpace
    {
        static public PlaneSpace GetPlaneSpace(this Plane item)
        {
            return new PlaneSpace(item);
        }
    }
}