using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    [AddComponentMenu("Pathfinding2D/PathNode2D/PathNode2D_FullyStatic")]
    public class PathNode2D_FullyStatic : PathNode2D
    {
        [SerializeField][HideInInspector]private List<PathNode2D> connections;

        public override void OnAddedToPathGraph()
        {
            connections = CalculateConnections().ToList();
        }

        public override IEnumerable<PathNode2D> GetConnections()
        {
            return connections;
        }
    }
}