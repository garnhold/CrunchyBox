using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Texture2DExtensions_Stamps
    {
        static public Stamp<float> CreateAlphaStamp(this Texture2D item)
        {
            return item.CreateAlphaGrid().CreateStamp();
        }

        static public Stamp<float> CreateGrayscaleStamp(this Texture2D item)
        {
            return item.CreateGrayscaleGrid().CreateStamp();
        }
    }
}