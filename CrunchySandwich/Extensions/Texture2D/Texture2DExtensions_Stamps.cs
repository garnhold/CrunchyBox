using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
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