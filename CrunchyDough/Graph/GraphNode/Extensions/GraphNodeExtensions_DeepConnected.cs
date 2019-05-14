using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class GraphNodeExtensions_DeepConnected
    {
        static public IEnumerable<T> GetDeepConnectedGraphNodes<T>(this T item, int max_depth) where T : GraphNode<T>
        {
            return item.TraverseWeb(i => i.GetConnectedGraphNodes(), max_depth);
        }
        static public IEnumerable<T> GetDeepConnectedGraphNodes<T>(this T item) where T : GraphNode<T>
        {
            return item.GetDeepConnectedGraphNodes(int.MaxValue);
        }

        static public bool IsDeepConnectedTo<T>(this T item, T to_check, int max_depth) where T : GraphNode<T>
        {
            return item.GetDeepConnectedGraphNodes<T>(max_depth).Has(to_check);
        }
        static public bool IsDeepConnectedTo<T>(this T item, T to_check) where T : GraphNode<T>
        {
            return item.IsDeepConnectedTo<T>(to_check, int.MaxValue);
        }
    }
}