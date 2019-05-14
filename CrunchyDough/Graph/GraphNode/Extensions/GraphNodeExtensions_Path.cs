using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class GraphNodeExtensions_Path
    {
        static public IEnumerable<T> GetAnOptimalPath<T>(this T item, double target_distance) where T : GraphNode<T>
        {
            return new GraphNodeNavigator<T>(item, new GraphNodeNavigator_MinimumDistance<T>(target_distance))
                .GetPathPermissive();
        }

        static public IEnumerable<T> GetOptimalPathTo<T>(this T item, T target) where T : GraphNode<T>
        {
            return new GraphNodeNavigator<T>(item, new GraphNodeNavigatorGoal_GraphNode<T>(target))
                .GetPath();
        }
    }
}