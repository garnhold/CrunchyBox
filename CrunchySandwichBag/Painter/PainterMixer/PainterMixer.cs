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
    [CustomAssetCategory("Painter/Mixer")]
    public abstract class PainterMixer : CustomAsset
    {
        public abstract Mixer<Color> CreateMixer();
    }
}