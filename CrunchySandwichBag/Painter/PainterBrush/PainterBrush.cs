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

namespace CrunchySandwichBag
{
    [AssetClassCategory("Painter/Brush")]
    public abstract class PainterBrush : CustomAsset
    {
        public abstract Brush<Color> CreateBrush(float size);
    }
}