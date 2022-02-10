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

        public RectF2Packer<T> Pack()
        {
            double total_area = objects_to_pack
                .Convert(o => size_operation(o).GetComponentsProduct())
                .Sum();

            List<T> sorted = objects_to_pack
                .Sort(o => -size_operation(o).GetComponentsProduct())
                .ToList();

            foreach (VectorF2 size in sizes)
            {
                if (size.GetComponentsProduct() >= total_area)
                {
                    RectF2Packer<T> packer = new RectF2Packer<T>(size, size_operation);

                    if (sorted.AreAll(o => packer.Pack(o)))
                        return packer;
                }
            }

            return null;
        }
    }
}