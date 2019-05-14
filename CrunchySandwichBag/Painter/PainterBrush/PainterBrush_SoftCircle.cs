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