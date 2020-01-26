using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Strudel
{
    using Dough;
    
    public class MarkDefinition
    {
        private int[] intersections;
        private int hash_code;

        static public MarkDefinition Create(IEnumerable<VectorF2> p)
        {
            return Create(p.ConvertToLineSegmentF2s());
        }

        static public MarkDefinition Create(IEnumerable<LineSegmentF2> l)
        {
            List<LineSegmentF2> line_segments = l.ToList();
            List<Tuple<float, float>> intersection_indexs = new List<Tuple<float, float>>();

            for (int i = 0; i < line_segments.Count; i++)
            {
                for (int j = 0; j < i - 1; j++)
                {
                    float percent_i;
                    float percent_j;

                    LineSegmentF2 line_segment_i = line_segments[i];
                    LineSegmentF2 line_segment_j = line_segments[j];

                    if (line_segment_i.TryGetIntersectionPercent(line_segment_j, out percent_i))
                    {
                        if (line_segment_j.TryGetIntersectionPercent(line_segment_i, out percent_j))
                            intersection_indexs.Add(Tuple.New(i + percent_i, j + percent_j));
                    }
                }
            }

            return new MarkDefinition(
                intersection_indexs
                    .Sort(t => t.item1)
                    .ConvertWithIndex((i, t) => Tuple.New(i, t.item2))
                    .Sort(t => t.item2)
                    .Convert(t => t.item1)
            );
        }

        public MarkDefinition(IEnumerable<int> i)
        {
            intersections = i.ToArray();

            hash_code = intersections.GetElementsHashCode();
        }

        public MarkDefinition(params int[] i) : this((IEnumerable<int>)i) { }

        public IEnumerable<int> GetIntersections()
        {
            return intersections;
        }

        public override int GetHashCode()
        {
            return hash_code;
        }

        public override bool Equals(object obj)
        {
            MarkDefinition cast;

            if (obj.Convert<MarkDefinition>(out cast))
            {
                if (cast.intersections.AreElementsEqual(intersections))
                    return true;
            }

            return false;
        }

        public override string ToString()
        {
            return "<" + intersections.ToString(", ") + ">";
        }
    }
}