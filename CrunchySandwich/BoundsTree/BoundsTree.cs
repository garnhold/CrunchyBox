using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public partial class BoundsTree<T> : IEnumerable<T>
    {
        private Bounds bounds;

        private bool is_subdivided;
        private List<T> child_items;
        private List<BoundsTree<T>> child_bounds;

        private int depth;
        private int target_number_items;
        
        private Operation<Bounds, T> get_bounds_operation;
        private Operation<IEnumerable<Bounds>, Bounds> get_subdivisions_operation;

        private bool AddToChildItems(T item)
        {
            child_items.Add(item);

            if (child_items.Count > target_number_items)
                Subdivide();

            return true;
        }
        private void Subdivide()
        {
            if (depth > 0 && is_subdivided == false)
            {
                child_bounds.Set(
                    get_subdivisions_operation(bounds)
                        .Convert(b => new BoundsTree<T>(b, depth - 1, target_number_items, get_bounds_operation, get_subdivisions_operation))
                );
                is_subdivided = true;

                child_items.Process(c => AddToChildBounds(c));
                child_items.Clear();
            }
        }

        private bool AddToChildBounds(T item)
        {
            child_bounds.Process(c => c.Add(item));

            return true;
        }

        public BoundsTree(Bounds b, int d, int t, Operation<Bounds, T> gb, Operation<IEnumerable<Bounds>, Bounds> gs)
        {
            bounds = b;

            child_items = new List<T>();
            child_bounds = new List<BoundsTree<T>>();

            depth = d;
            target_number_items = t;

            get_bounds_operation = gb;
            get_subdivisions_operation = gs;
        }

        public BoundsTree(Bounds b, int d, int t, Operation<Bounds, T> gb, Operation<IEnumerable<Bounds>, Bounds> gs, IEnumerable<T> i) : this(b, d, t, gb, gs)
        {
            this.AddRange(i);
        }
        public BoundsTree(Bounds b, int d, int t, Operation<Bounds, T> gb, Operation<IEnumerable<Bounds>, Bounds> gs, params T[] i) : this(b, d, t, gb, gs, (IEnumerable<T>)i) { }

        public bool Add(T item)
        {
            Bounds item_bounds = get_bounds_operation(item);

            if (bounds.Intersects(item_bounds))
            {
                if (is_subdivided)
                    return AddToChildBounds(item);

                return AddToChildItems(item);
            }

            return false;
        }

        public IEnumerable<T> GetItemsWithin(Predicate<Bounds> predicate)
        {
            if (predicate.DoesDescribe(bounds))
            {
                if (is_subdivided)
                    return child_bounds.Convert(c => c.GetItemsWithin(predicate));

                return child_items.Narrow(c => predicate.DoesDescribe(get_bounds_operation(c)));
            }

            return Empty.IEnumerable<T>();
        }

        public Bounds GetBounds()
        {
            return bounds;
        }

        public IEnumerable<T> GetItems()
        {
            if (is_subdivided)
                return child_bounds.Convert(c => c.GetItems());

            return child_items;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return GetItems().GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}