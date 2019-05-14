using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class RectExtensions_Split_Center
    {
        static public void SplitByXCenter(this Rect item, out Rect left, out Rect right)
        {
            item.SplitByX(item.center.x, out left, out right);
        }

        static public void SplitByYCenter(this Rect item, out Rect bottom, out Rect top)
        {
            item.SplitByY(item.center.y, out bottom, out top);
        }
    }
}