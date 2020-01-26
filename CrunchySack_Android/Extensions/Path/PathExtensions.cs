using System;
using System.Collections;
using System.Collections.Generic;

using Android;
using Android.App;
using Android.Views;
using Android.Content;
using Android.Graphics;
using Android.Content.Res;

namespace Crunchy.Sack_Android
{
    using Dough;    using Sack;
    
    static public class PathExtensions
    {
        static public Path CreatePolygon(IEnumerable<VectorF2> points)
        {
            Path path = new Path();

            path.Loop(points);
            return path;
        }
        static public Path CreatePolygon(params VectorF2[] points)
        {
            return CreatePolygon((IEnumerable<VectorF2>)points);
        }

        static public Path CreateRegularPolygon(int number_points, float radius)
        {
            return CreatePolygon(
                Floats.Line(0.0f, 360.0f, number_points, false)
                    .Convert(a => VectorF2Extensions.CreateDirectionFromDegrees(a) * radius)
            );
        }
    }
}