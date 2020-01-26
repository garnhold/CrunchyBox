using System;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Salt;
    using Noodle;    using Sauce;
    using Sandwich;
    
    public class PainterBrush_SoftCircle : PainterBrush
    {
        [SerializeField][Range(0.0f, 1.0f)]private float hardness;
        [SerializeField][Range(0.0f, 2.0f)]private float power;

        public override Brush<Color> CreateBrush(float size)
        {
            return new Brush_Stamp<Color>(
                Stamps.SoftCircle<float>(size * 0.5f, hardness, power, f => f)
            );
        }
    }
}