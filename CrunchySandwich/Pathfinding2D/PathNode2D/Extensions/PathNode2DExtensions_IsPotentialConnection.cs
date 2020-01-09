using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class PathNode2DExtensions_IsPotentialConnection
    {
        static public bool IsPotentialConnection(this PathNode2D item, Component component)
        {
            return item.IsPotentialConnection(component.GetPlanarPosition());
        }
    }
}