using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    public partial class RectTree<T>
    {
        static public RectTree<T> CreateQuadtree(Rect rect, int depth, int target_number_items, Operation<Rect, T> operation)
        {
            return new RectTree<T>(
                rect,
                depth,
                target_number_items,
                operation,
                RectExtensions_SplitIntoQuarters.SplitIntoQuarters
            );
        }
        static public RectTree<T> CreateQuadtree(Rect bounds, int depth, int target_number_items, Operation<Rect, T> operation, IEnumerable<T> items)
        {
            RectTree<T> tree = CreateQuadtree(bounds, depth, target_number_items, operation);

            tree.AddRange(items);
            return tree;
        }
        static public RectTree<T> CreateQuadtree(Rect bounds, int depth, int target_number_items, Operation<Rect, T> operation, params T[] items)
        {
            return CreateQuadtree(bounds, depth, target_number_items, operation, (IEnumerable<T>)items);
        }
    }
}