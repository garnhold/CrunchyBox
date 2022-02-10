using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class RectF2Packer<T>
    {
        private VectorF2 size;

        private List<RectF2> remaining_rects;
        private Dictionary<T, RectF2> packed_objects;

        private Operation<VectorF2, T> size_operation;

        static public IEnumerable<KeyValuePair<T, RectF2>> ExpandPack(IEnumerable<T> items, IEnumerable<VectorF2> sizes, Operation<VectorF2, T> size_operation, out VectorF2 full_size, int quality = 1)
        {
            List<T> objects_to_pack = items.ToList();

            double total_area = objects_to_pack
                .Convert(o => size_operation(o).GetComponentsProduct())
                .Sum();

            List<T> fair_sorted = objects_to_pack
                .Sort(o => -size_operation(o).GetComponentsProduct())
                .ToList();

            int number_swaps = (int)(fair_sorted.Count * 0.10f);

            List<List<T>> sorted = (quality - 2)
                .RepeatOperationWithIndex(i => fair_sorted.RandomizeNearSwaps(number_swaps * ((i / 5) + 1), 3).ToList())
                .Prepend(fair_sorted)
                .PrependIf(quality >= 2,
                    () => objects_to_pack
                        .Sort(o => -size_operation(o).GetComponentsMax())
                        .ToList()
                )
                .ToList();

            foreach (VectorF2 size in sizes)
            {
                if (size.GetComponentsProduct() >= total_area)
                {
                    for (int i = 0; i < quality; i++)
                    {
                        RectF2Packer<T> packer = new RectF2Packer<T>(size, size_operation);

                        if (sorted[i].AreAll(o => packer.Pack(o)))
                        {
                            full_size = size;
                            return objects_to_pack
                                .ConvertToKeyOfPair(o => packer.GetPackedRect(o));
                        }
                    }
                }
            }

            full_size = VectorF2.ZERO;
            return null;
        }

        public RectF2Packer(VectorF2 s, Operation<VectorF2, T> so)
        {
            size = s;

            remaining_rects = new List<RectF2>();
            packed_objects = new Dictionary<T, RectF2>();

            size_operation = so;

            remaining_rects.Add(RectF2Extensions.CreateLowerLeftRectF2(VectorF2.ZERO, size));
        }

        public RectF2Packer(float width, float height, Operation<VectorF2, T> so) : this(new VectorF2(width, height), so) { }

        public bool Pack(T to_pack)
        {
            RectF2 best_rect;
            VectorF2 size = size_operation(to_pack);

            if (remaining_rects
                .Narrow(r => size.IsBoundBelow(r.GetSize()))
                .TryFindLowestRated(r => (r.GetSize() - size).GetComponentsMax(), out best_rect))
            {
                RectF2 pack_rect = RectF2Extensions.CreateLowerLeftRectF2(best_rect.GetLowerLeftPoint(), size);

                remaining_rects.Remove(best_rect);
                remaining_rects.AddRange(best_rect.GetSubtraction(pack_rect));

                packed_objects.Add(to_pack, pack_rect);
                return true;
            }

            return false;
        }

        public VectorF2 GetSize()
        {
            return size;
        }

        public RectF2 GetPackedRect(T obj)
        {
            return packed_objects.GetValue(obj);
        }

        public IEnumerable<KeyValuePair<T, RectF2>> GetPacked()
        {
            return packed_objects;
        }
    }
}