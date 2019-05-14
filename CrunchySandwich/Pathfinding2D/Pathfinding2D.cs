using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class Pathfinding2D : Subsystem
    {
        [SerializeField]private float connection_radius;
        [SerializeField]private float connection_fudge_distance;

        [SerializeField]private float max_clearing_radius;

        [SerializeField]private LayerEX node_layer;
        [SerializeField]private LayerMask dynamic_obstacle_layer_mask;
        [SerializeField]private LayerMask static_obstacle_layer_mask;

        static public Pathfinding2D GetInstance()
        {
            return Subsystem.GetInstance<Pathfinding2D>();
        }

        private bool IsConnection(Vector2 position1, Vector2 position2, int layer_mask)
        {
            RayLine2 line = new RayLine2(position1, position2);

            if (line.CircleCast(connection_radius, layer_mask) == false)
                return true;

            return false;
        }
        public bool IsConnection(Vector2 position1, Vector2 position2)
        {
            return IsConnection(position1, position2, dynamic_obstacle_layer_mask | static_obstacle_layer_mask);
        }
        public bool IsPotentialConnection(Vector2 position1, Vector2 position2)
        {
            return IsConnection(position1, position2, static_obstacle_layer_mask);
        }

        private float GetClearingRadius(Vector2 position, int layer_mask, bool include_nodes)
        {
            if (include_nodes)
                layer_mask |= node_layer;

            return Physics2DExtensions.FindLargestCircleFit(position, max_clearing_radius, layer_mask, 0.01f, 64);
        }
        public float GetClearingRadius(Vector2 position, bool include_nodes = false)
        {
            return GetClearingRadius(position, dynamic_obstacle_layer_mask | static_obstacle_layer_mask, include_nodes);
        }
        public float GetPotentialClearingRadius(Vector2 position, bool include_nodes = false)
        {
            return GetClearingRadius(position, static_obstacle_layer_mask, include_nodes);
        }

        private float GetFixedEdgeClearingRadius(Vector2 position, Vector2 direction, int layer_mask, bool include_nodes)
        {
            if (include_nodes)
                layer_mask |= node_layer;

            return Physics2DExtensions.FindLargestFixedEdgeCircleFit(position, direction, max_clearing_radius, layer_mask, 0.01f, 64);
        }
        public float GetFixedEdgeClearingRadius(Vector2 position, Vector2 direction, bool include_nodes = false)
        {
            return GetFixedEdgeClearingRadius(position, direction, dynamic_obstacle_layer_mask | static_obstacle_layer_mask, include_nodes);
        }
        public float GetPotentialFixedEdgeClearingRadius(Vector2 position, Vector2 direction, bool include_nodes = false)
        {
            return GetFixedEdgeClearingRadius(position, direction, static_obstacle_layer_mask, include_nodes);
        }

        public PathNode2D GetPathNodeNear(Vector2 position, float maximum_distance)
        {
            return GetPathNodes(position, maximum_distance).GetPlanarClosest(position);
        }

        public PathNode2D GetConnectionNear(Vector2 position, float maximum_distance)
        {
            return GetConnections(position, maximum_distance).GetPlanarClosest(position);
        }

        public PathNode2D GetPotentialConnectionNear(Vector2 position, float maximum_distance)
        {
            return GetPotentialConnections(position, maximum_distance).GetPlanarClosest(position);
        }

        public IEnumerable<PathNode2D> GetPathNodes(Vector2 position, float radius)
        {
            return Physics2DExtensions.OverlapCircleAll(position, radius + connection_fudge_distance, node_layer)
                .ConvertComponent<Collider2D, PathNode2D>();
        }

        public IEnumerable<PathNode2D> GetConnections(Vector2 position, float radius)
        {
            return GetPathNodes(position, radius)
                .Narrow(p => p.IsConnection(position));
        }

        public IEnumerable<PathNode2D> GetPotentialConnections(Vector2 position, float radius)
        {
            return GetPathNodes(position, radius)
                .Narrow(p => p.IsPotentialConnection(position));
        }

        public LayerEX GetNodeLayer()
        {
            return node_layer;
        }
    }
}