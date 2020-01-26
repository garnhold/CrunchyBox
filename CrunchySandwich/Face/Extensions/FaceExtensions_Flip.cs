using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class FaceExtensions_Flip
    {
        static public Face GetFlipped(this Face item)
        {
            return new Face(item.v1, item.v0);
        }
    }
}