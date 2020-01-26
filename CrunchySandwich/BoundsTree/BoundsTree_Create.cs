using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    public partial class BoundsTree<T>
    {
        static public BoundsTree<T> CreateOctree(Bounds bounds, int depth, int target_number_items, Operation<Bounds, T> operation)
        {
            return new BoundsTree<T>(
                bounds,
                depth,
                target_number_items,
                operation,
                BoundsExtensions_SplitIntoSpaceEighths.SplitIntoSpaceEighths
            );
        }
        static public BoundsTree<T> CreateOctree(Bounds bounds, int depth, int target_number_items, Operation<Bounds, T> operation, IEnumerable<T> items)
        {
            BoundsTree<T> tree = CreateOctree(bounds, depth, target_number_items, operation);

            tree.AddRange(items);
            return tree;
        }
        static public BoundsTree<T> CreateOctree(Bounds bounds, int depth, int target_number_items, Operation<Bounds, T> operation, params T[] items)
        {
            return CreateOctree(bounds, depth, target_number_items, operation, (IEnumerable<T>)items);
        }

        static public BoundsTree<T> CreateAreaQuadtree(Bounds bounds, int depth, int target_number_items, Operation<Bounds, T> operation)
        {
            return new BoundsTree<T>(
                bounds,
                depth,
                target_number_items,
                operation,
                BoundsExtensions_SplitIntoAreaQuarters.SplitIntoAreaQuarters
            );
        }
        static public BoundsTree<T> CreateAreaQuadtree(Bounds bounds, int depth, int target_number_items, Operation<Bounds, T> operation, IEnumerable<T> items)
        {
            BoundsTree<T> tree = CreateAreaQuadtree(bounds, depth, target_number_items, operation);

            tree.AddRange(items);
            return tree;
        }
        static public BoundsTree<T> CreateAreaQuadtree(Bounds bounds, int depth, int target_number_items, Operation<Bounds, T> operation, params T[] items)
        {
            return CreateAreaQuadtree(bounds, depth, target_number_items, operation, (IEnumerable<T>)items);
        }

        static public BoundsTree<T> CreatePlanarQuadtree(Bounds bounds, int depth, int target_number_items, Operation<Bounds, T> operation)
        {
            return new BoundsTree<T>(
                bounds,
                depth,
                target_number_items,
                operation,
                BoundsExtensions_SplitIntoPlanarQuarters.SplitIntoPlanarQuarters
            );
        }
        static public BoundsTree<T> CreatePlanarQuadtree(Bounds bounds, int depth, int target_number_items, Operation<Bounds, T> operation, IEnumerable<T> items)
        {
            BoundsTree<T> tree = CreatePlanarQuadtree(bounds, depth, target_number_items, operation);

            tree.AddRange(items);
            return tree;
        }
        static public BoundsTree<T> CreatePlanarQuadtree(Bounds bounds, int depth, int target_number_items, Operation<Bounds, T> operation, params T[] items)
        {
            return CreatePlanarQuadtree(bounds, depth, target_number_items, operation, (IEnumerable<T>)items);
        }
    }
}