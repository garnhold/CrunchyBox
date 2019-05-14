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
    public class PainterMixer_SimpleNormal : PainterMixer
    {
        public override Mixer<Color> CreateMixer()
        {
            return new Mixer_Color_Simple_Normal();
        }
    }
}