using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class Texture2DExtensions_Index
    {
        static public bool IsIndexValid(this Texture2D item, int x, int y)
        {
            if (item != null)
            {
                if (x >= 0 && x < item.width)
                {
                    if (y >= 0 && y < item.height)
                        return true;
                }
            }

            return false;
        }
    }
}