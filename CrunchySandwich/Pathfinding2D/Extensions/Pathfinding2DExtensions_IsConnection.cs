using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class Pathfinding2DExtensions_IsConnection
    {
        static public bool IsConnection(this Pathfinding2D item, Component component, Vector2 position)
        {
            return item.IsConnection(component.GetPlanarPosition(), position);
        }

        static public bool IsConnection(this Pathfinding2D item, Vector2 position, Component component)
        {
            return item.IsConnection(position, component.GetPlanarPosition());
        }

        static public bool IsConnection(this Pathfinding2D item, Component component1, Component component2)
        {
            return item.IsConnection(component1.GetPlanarPosition(), component2.GetPlanarPosition());
        }
    }
}