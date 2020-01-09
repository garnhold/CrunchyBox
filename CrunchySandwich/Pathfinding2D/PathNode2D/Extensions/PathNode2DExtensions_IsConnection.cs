using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class PathNode2DExtensions_IsConnection
    {
        static public bool IsConnection(this PathNode2D item, Component component)
        {
            return item.IsConnection(component.GetPlanarPosition());
        }
    }
}