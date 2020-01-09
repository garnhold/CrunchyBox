using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    public class PathNavigator2D
    {
        private int waypoint_index;
        private List<Vector2> waypoints;

        public PathNavigator2D(IEnumerable<Vector2> n)
        {
            waypoint_index = 0;
            waypoints = n.ToList();
        }

        public PathNavigator2D(params Vector2[] n) : this((IEnumerable<Vector2>)n) { }

        public PathNavigator2D(IEnumerable<PathNode2D> n, Vector2 fp) : this(n.Convert(z => z.GetPlanarPosition()).Append(fp)) { }
        public PathNavigator2D(IEnumerable<PathNode2D> n) : this(n.Convert(z => z.GetPlanarPosition())) { }

        public bool Update(Vector2 position)
        {
            if (waypoint_index < waypoints.Count)
            {
                if (Pathfinding2D.GetInstance().IsPotentialConnection(position, GetNextTargetPosition()))
                    waypoint_index++;

                return true;
            }

            return false;
        }

        public bool TryAlterDestination(Vector2 destination)
        {
            int final_index;
            Pathfinding2D pathfinding = Pathfinding2D.GetInstance();

            if (waypoints.Offset(waypoint_index).TryApproximateEarliestEdge(
                p => pathfinding.IsConnection(p, destination), out final_index)
            )
            {
                waypoints.RemoveEnding(waypoint_index + final_index + 1);
                waypoints.Add(destination);
                return true;
            }

            return false;
        }

        public Vector2 GetCurrentTargetPosition()
        {
            return waypoints.GetCapped(waypoint_index);
        }

        public Vector2 GetNextTargetPosition()
        {
            return waypoints.GetCapped(waypoint_index + 1);
        }

        public Vector2 GetFinalTargetPosition()
        {
            return waypoints.GetLast();
        }

        public IEnumerable<Vector2> GetTargetPositions()
        {
            return waypoints;
        }

        public IEnumerable<Vector2> GetRemainingTargetPositions()
        {
            return waypoints.Offset(waypoint_index);
        }
    }
}