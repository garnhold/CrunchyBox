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
    using Noodle;
    using Bun;
    using Sauce;
    using Sandwich;
    
    public class PainterBrush_Circle : PainterBrush
    {
        public override Brush<Color> CreateBrush(float size)
        {
            return new Brush_Stamp<Color>(Stamps.Circle<float>(size * 0.5f, 1.0f));
        }
    }
}