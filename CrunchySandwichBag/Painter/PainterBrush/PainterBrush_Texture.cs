using System;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySauce;
using CrunchySandwich;

using CrunchyBun;

namespace CrunchySandwichBag
{
    public class PainterBrush_Texture : PainterBrush
    {
        [SerializeField]private Texture2D texture;

        public override Brush<Color> CreateBrush(float size)
        {
            return new Brush_Stamp<Color>(
                texture.CreateAlphaStamp()
            );
        }
    }
}