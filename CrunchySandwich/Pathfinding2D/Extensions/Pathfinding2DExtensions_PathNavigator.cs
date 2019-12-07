using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Noodle;
    using Bun;
    
    static public class Pathfinding2DExtensions_PathNavigator
    {
        static public PathNavigator2D GetPathNavigatorToWander(this Pathfinding2D item, Vector2 origin, float target_distance)
        {
            PathNode2D origin_node = item.GetConnectionNear(origin);

            if (origin_node != null)
            {
                return new PathNavigator2D(
                    origin_node.GetWanderingRandomPath(target_distance)
                );
            }

            return null;
        }

        static public PathNavigator2D GetPathNavigatorToWander(this Pathfinding2D item, Vector2 origin, float target_distance, float max_angle_delta)
        {
            PathNode2D origin_node = item.GetConnectionNear(origin);

            if (origin_node != null)
            {
                return new PathNavigator2D(
                    origin_node.GetWanderingAngleLimitedDegreesPath(target_distance, max_angle_delta)
                );
            }

            return null;
        }

        static public PathNavigator2D GetPathNavigatorToDestination(this Pathfinding2D item, Vector2 origin, Vector2 destination)
        {
            if (item.IsConnection(origin, destination))
                return new PathNavigator2D(destination);
            else
            {
                PathNode2D origin_node = item.GetConnectionNear(origin);
                PathNode2D destination_node = item.GetConnectionNear(destination);

                if (origin_node != null && destination_node != null)
                {
                    return new PathNavigator2D(
                        origin_node.GetOptimalPathTo(destination_node),
                        destination
                    );
                }
            }

            return null;
        }
    }
}