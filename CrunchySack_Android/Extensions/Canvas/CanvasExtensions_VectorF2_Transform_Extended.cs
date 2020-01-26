using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using Android;
using Android.App;
using Android.Graphics;

namespace Crunchy.Sack_Android
{
    using Dough;    using Sack;
    
    static public class CanvasExtensions_VectorF2_Transform_Extended
    {
        static public void Transform(this Canvas item, VectorF2 position, float angle, VectorF2 scale)
        {
            item.Translate(position);
            item.Rotate(angle);
            item.Scale(scale);
        }
        static public void PushPopTransform(this Canvas item, VectorF2 position, float angle, VectorF2 scale, Process process)
        {
            item.Save();
                item.Transform(position, angle, scale);
                process();
            item.Restore();
        }
        static public void PushPopTransform(this Canvas item, VectorF2 position, float angle, Process process)
        {
            item.PushPopTransform(position, angle, VectorF2.ONE, process);
        }
        static public void PushPopTransform(this Canvas item, VectorF2 position, Process process)
        {
            item.PushPopTransform(position, 0.0f, process);
        }
    }
}