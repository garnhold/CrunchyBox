using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class RectF2Packer<T>
    {
        private RectF2 full_rect;

        private List<RectF2> remaining_rects;
        private Dictionary<T, RectF2> packed_objects;

        private Operation<VectorF2, T> size_operation;

        public RectF2Packer(RectF2 r, Operation<VectorF2, T> so)
        {
            full_rect = r;

            remaining_rects = new List<RectF2>();
            packed_objects = new Dictionary<T, RectF2>();

            size_operation = so;

            remaining_rects.Add(full_rect);
        }

        public RectF2Packer(VectorF2 size, Operation<VectorF2, T> so) : this(RectF2Extensions.CreateLowerLeftRectF2(VectorF2.ZERO, size), so) { }
        public RectF2Packer(float width, float height, Operation<VectorF2, T> so) : this(new VectorF2(width, height), so) { }

        public bool Pack(T to_pack)
        {
            RectF2 best_rect;
            double best_rating;
            int best_rect_index;

            VectorF2 size = size_operation(to_pack);

            if (remaining_rects
                .Narrow(r => size.IsBoundBelow(r.GetSize()))
                .TryFindLowestRated(r => (r.GetSize() - size).GetComponentsMax(), out best_rect, out best_rating, out best_rect_index))
            {
                RectF2 pack_rect = RectF2Extensions.CreateLowerLeftRectF2(best_rect.GetLowerLeftPoint(), size);

                remaining_rects.RemoveAt(best_rect_index);
                remaining_rects.AddRange(best_rect.GetSubtraction(pack_rect));

                packed_objects.Add(to_pack, pack_rect);
                return true;
            }

            return false;
        }

        public IEnumerable<KeyValuePair<T, RectF2>> GetPacked()
        {
            return packed_objects;
        }
    }
}