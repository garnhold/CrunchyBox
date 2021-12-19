using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class Texture2DExtensions_Aspect
    {
        static public float GetAspect(this Texture2D item)
        {
            return item.height / item.width;
        }
    }
}