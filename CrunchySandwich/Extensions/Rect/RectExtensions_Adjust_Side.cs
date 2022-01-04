using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
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

        static public Rect GetAdjusted(this Rect item, float amount, RectSide side)
        {
            switch (side)
            {
                case RectSide.Left: return item.GetAdjustedLeft(amount);
                case RectSide.Right: return item.GetAdjustedRight(amount);
                case RectSide.Bottom: return item.GetAdjustedBottom(amount);
                case RectSide.Top: return item.GetAdjustedTop(amount);
            }

            throw new UnaccountedBranchException("side", side);
        }
        static public Rect GetEnlarged(this Rect item, float amount, RectSide side)
        {
            switch (side)
            {
                case RectSide.Left: return item.GetEnlargedLeft(amount);
                case RectSide.Right: return item.GetEnlargedRight(amount);
                case RectSide.Bottom: return item.GetEnlargedBottom(amount);
                case RectSide.Top: return item.GetEnlargedTop(amount);
            }

            throw new UnaccountedBranchException("side", side);
        }
        static public Rect GetShrunk(this Rect item, float amount, RectSide side)
        {
            switch (side)
            {
                case RectSide.Left: return item.GetShrunkLeft(amount);
                case RectSide.Right: return item.GetShrunkRight(amount);
                case RectSide.Bottom: return item.GetShrunkBottom(amount);
                case RectSide.Top: return item.GetShrunkTop(amount);
            }

            throw new UnaccountedBranchException("side", side);
        }
    }
}