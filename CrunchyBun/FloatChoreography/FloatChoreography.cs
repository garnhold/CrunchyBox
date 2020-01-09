using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bun
{
    using Dough;
    
    public class FloatChoreography
    {
        private SortedList<float, FloatChoreographyKeyFrame> key_frames;

        public FloatChoreography(IEnumerable<FloatChoreographyKeyFrame> ps)
        {
            key_frames = ps.ToSortedListValues(p => p.GetStart());
        }

        public FloatChoreography(params FloatChoreographyKeyFrame[] ps) : this((IEnumerable<FloatChoreographyKeyFrame>)ps) { }

        public float Evaluate(float x)
        {
            int index = key_frames.FindNearestIndexByKey(x, BoundType.Below);
            int index_next = index + 1;

            if (index < 0)
                return key_frames.Values.GetFirst().GetValue();

            if (index >= key_frames.Count || index_next >= key_frames.Count)
                return key_frames.Values.GetLast().GetValue();

            return key_frames.Values[index].Evaluate(x, key_frames.Values[index_next]);
        }
    }
}