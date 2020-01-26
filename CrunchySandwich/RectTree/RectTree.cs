using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    public partial class RectTree<T> : IEnumerable<T>
    {
        private Rect rect;

        private bool is_subdivided;
        private List<T> child_items;
        private List<RectTree<T>> child_rects;

        private int depth;
        private int target_number_items;
        
        private Operation<Rect, T> get_rect_operation;
        private Operation<IEnumerable<Rect>, Rect> get_subdivisions_operation;

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
                child_rects.Set(
                    get_subdivisions_operation(rect)
                        .Convert(b => new RectTree<T>(b, depth - 1, target_number_items, get_rect_operation, get_subdivisions_operation))
                );
                is_subdivided = true;

                child_items.Process(c => AddToChildRect(c));
                child_items.Clear();
            }
        }

        private bool AddToChildRect(T item)
        {
            child_rects.Process(c => c.Add(item));

            return true;
        }

        public RectTree(Rect b, int d, int t, Operation<Rect, T> gb, Operation<IEnumerable<Rect>, Rect> gs)
        {
            rect = b;

            child_items = new List<T>();
            child_rects = new List<RectTree<T>>();

            depth = d;
            target_number_items = t;

            get_rect_operation = gb;
            get_subdivisions_operation = gs;
        }

        public RectTree(Rect b, int d, int t, Operation<Rect, T> gb, Operation<IEnumerable<Rect>, Rect> gs, IEnumerable<T> i) : this(b, d, t, gb, gs)
        {
            this.AddRange(i);
        }
        public RectTree(Rect b, int d, int t, Operation<Rect, T> gb, Operation<IEnumerable<Rect>, Rect> gs, params T[] i) : this(b, d, t, gb, gs, (IEnumerable<T>)i) { }

        public bool Add(T item)
        {
            Rect item_rect = get_rect_operation(item);

            if (rect.Overlaps(item_rect))
            {
                if (is_subdivided)
                    return AddToChildRect(item);

                return AddToChildItems(item);
            }

            return false;
        }

        public IEnumerable<T> GetItemsWithin(Predicate<Rect> predicate)
        {
            if (predicate.DoesDescribe(rect))
            {
                if (is_subdivided)
                    return child_rects.Convert(c => c.GetItemsWithin(predicate)).Flatten();

                return child_items.Narrow(c => predicate.DoesDescribe(get_rect_operation(c)));
            }

            return Empty.IEnumerable<T>();
        }

        public Rect GetRect()
        {
            return rect;
        }

        public IEnumerable<T> GetItems()
        {
            if (is_subdivided)
                return child_rects.Convert(c => c.GetItems()).Flatten();

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