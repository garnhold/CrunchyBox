using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sauce
{
    using Dough;
    
    public class SurfaceTool_PolygonSelection<T> : SurfaceTool<T>
    {
        public SurfaceSelection<T> PolygonSelect(Surface<T> surface, IEnumerable<VectorF2> points)
        {
            SurfaceSelection<T> selection = new SurfaceSelection<T>(surface);

            Spectrum<LineSegmentF2> y_spectrum = new Spectrum<LineSegmentF2>(
                points.CloseLoop().ConvertConnections((p1, p2) => new SpectrumBand<LineSegmentF2>(new LineSegmentF2(p1, p2), p1.y, p2.y))
            );

            for (float y = y_spectrum.GetLowerBound(); y < y_spectrum.GetUpperBound(); y++)
            {
                LineF2 scanline = new LineF2(new VectorF2(0.0f, y), new VectorF2(1.0f, 0.0f));

                y_spectrum.LookupData(y)
                    .Convert(l => {
                        VectorF2 point;

                        if (scanline.TryGetIntersection(l.GetLine(), out point))
                            return point.x;

                        return l.p1.x.Min(l.p2.x);
                    })
                    .Sort(z => z)
                    .ConvertConnections((p, c) => Tuple.New(p, c))
                    .SkipEvery(1)
                    .Process(t =>
                        selection.AddRectangle(
                            new VectorF2(t.item1, y),
                            new VectorF2(t.item2, y)
                        )
                    );
            }

            return selection;
        }
        public SurfaceSelection<T> PolygonSelect(Surface<T> surface, params VectorF2[] points)
        {
            return PolygonSelect(surface, (IEnumerable<VectorF2>)points);
        }
    }
}