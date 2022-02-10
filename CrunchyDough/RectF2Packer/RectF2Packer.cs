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