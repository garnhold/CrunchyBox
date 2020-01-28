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
    using Sauce;
    using Sandwich;
    
    public class PainterBrush_Texture : PainterBrush
    {
        [SerializeField]private Texture2D texture;

        public override Brush<Color> CreateBrush(float size)
        {
            return new Brush_Grid<Color>(texture.CreateAlphaGrid());
        }
    }
}