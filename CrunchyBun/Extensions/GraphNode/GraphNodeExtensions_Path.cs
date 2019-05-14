using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyBun
{
    static public class GraphNodeExtensions_Path
    {
        static public IEnumerable<T> GetWanderingRandomPath<T>(this T item, float target_distance) where T : GraphNode<T>
        {
            return new GraphNodeWanderer_Random<T>(item, target_distance).GetPathPermissive();
        }

        static public IEnumerable<T> GetWanderingAngleLimitedRadiansPath<T>(this T item, float target_distance, float maximum_angle_delta) where T : GraphNode_AngleAware_Radians<T>
        {
            return new GraphNodeWanderer_AngleLimited_Radians<T>(item, target_distance, maximum_angle_delta).GetPathPermissive();
        }

        static public IEnumerable<T> GetWanderingAngleLimitedDegreesPath<T>(this T item, float target_distance, float maximum_angle_delta) where T : GraphNode_AngleAware_Degrees<T>
        {
            return new GraphNodeWanderer_AngleLimited_Degrees<T>(item, target_distance, maximum_angle_delta).GetPathPermissive();
        }

        static public IEnumerable<T> GetWanderingAngleLimitedPercentPath<T>(this T item, float target_distance, float maximum_angle_delta) where T : GraphNode_AngleAware_Percent<T>
        {
            return new GraphNodeWanderer_AngleLimited_Percent<T>(item, target_distance, maximum_angle_delta).GetPathPermissive();
        }
    }
}