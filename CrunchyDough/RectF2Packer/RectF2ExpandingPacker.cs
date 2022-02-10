using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class RectF2ExpandingPacker<T>
    {
        private List<T> objects_to_pack;
        private IEnumerable<VectorF2> sizes;

        private Operation<VectorF2, T> size_operation;

        public RectF2ExpandingPacker(IEnumerable<VectorF2> s, Operation<VectorF2, T> so)
        {
            objects_to_pack = new List<T>();
            sizes = s;

            size_operation = so;
        }

        public void Add(T to_pack)
        {
            objects_to_pack.Add(to_pack);
        }

        public IEnumerable<KeyValuePair<T, RectF2>> Pack(out VectorF2 full_size, int quality=1)
        {
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
    }
}