using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class RectExtensions_Adjust_Side
    {
        static public Rect GetAdjustedLeft(this Rect item, float amount)
        {
            return item.GetAdjusted(amount, 0.0f, 0.0f, 0.0f);
        }
        static public Rect GetEnlargedLeft(this Rect item, float amount)
        {
            return item.GetEnlarged(amount, 0.0f, 0.0f, 0.0f);
        }
        static public Rect GetShrunkLeft(this Rect item, float amount)
        {
            return item.GetShrunk(amount, 0.0f, 0.0f, 0.0f);
        }

        static public Rect GetAdjustedRight(this Rect item, float amount)
        {
            return item.GetAdjusted(0.0f, 0.0f, amount, 0.0f);
        }
        static public Rect GetEnlargedRight(this Rect item, float amount)
        {
            return item.GetEnlarged(0.0f, 0.0f, amount, 0.0f);
        }
        static public Rect GetShrunkRight(this Rect item, float amount)
        {
            return item.GetShrunk(0.0f, 0.0f, amount, 0.0f);
        }

        static public Rect GetAdjustedBottom(this Rect item, float amount)
        {
            return item.GetAdjusted(0.0f, amount, 0.0f, 0.0f);
        }
        static public Rect GetEnlargedBottom(this Rect item, float amount)
        {
            return item.GetEnlarged(0.0f, amount, 0.0f, 0.0f);
        }
        static public Rect GetShrunkBottom(this Rect item, float amount)
        {
            return item.GetShrunk(0.0f, amount, 0.0f, 0.0f);
        }

        static public Rect GetAdjustedTop(this Rect item, float amount)
        {
            return item.GetAdjusted(0.0f, 0.0f, 0.0f, amount);
        }
        static public Rect GetEnlargedTop(this Rect item, float amount)
        {
            return item.GetEnlarged(0.0f, 0.0f, 0.0f, amount);
        }
        static public Rect GetShrunkTop(this Rect item, float amount)
        {
            return item.GetShrunk(0.0f, 0.0f, 0.0f, amount);
        }
    }
}