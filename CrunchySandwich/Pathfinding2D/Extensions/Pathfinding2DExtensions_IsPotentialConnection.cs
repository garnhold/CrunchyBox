using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class Pathfinding2DExtensions_IsPotentialConnection
    {
        static public bool IsPotentialConnection(this Pathfinding2D item, Component component, Vector2 position)
        {
            return item.IsPotentialConnection(component.GetPlanarPosition(), position);
        }

        static public bool IsPotentialConnection(this Pathfinding2D item, Vector2 position, Component component)
        {
            return item.IsPotentialConnection(position, component.GetPlanarPosition());
        }

        static public bool IsPotentialConnection(this Pathfinding2D item, Component component1, Component component2)
        {
            return item.IsPotentialConnection(component1.GetPlanarPosition(), component2.GetPlanarPosition());
        }
    }
}