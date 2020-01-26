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
    
    public abstract class PainterBrush
    {
        public abstract Brush<Color> CreateBrush(float size);
    }
}