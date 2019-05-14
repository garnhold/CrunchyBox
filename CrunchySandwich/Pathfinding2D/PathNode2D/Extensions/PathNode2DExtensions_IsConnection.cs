using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class PathNode2DExtensions_IsConnection
    {
        static public bool IsConnection(this PathNode2D item, Component component)
        {
            return item.IsConnection(component.GetPlanarPosition());
        }
    }
}