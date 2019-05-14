using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using Android;
using Android.App;
using Android.Graphics;

using CrunchyDough;
using CrunchyBun;
using CrunchySack;

namespace CrunchySack_Android
{
    static public class CanvasExtensions_VectorF2_Transform
    {
        static public void Translate(this Canvas item, VectorF2 amount)
        {
            item.Translate(amount.x, amount.y);
        }

        static public void Scale(this Canvas item, VectorF2 amount)
        {
            item.Scale(amount.x, amount.y);
        }
        static public void Scale(this Canvas item, float amount)
        {
            item.Scale(amount, amount);
        }
    }
}