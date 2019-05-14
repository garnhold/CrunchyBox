using System;
using System.IO;

using Android;
using Android.App;
using Android.Views;
using Android.Content;
using Android.Content.Res;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySack;

namespace CrunchySack_Android
{
    static public class ViewExtensions_AnimatedFloat
    {
        static public AutoAnimatedFloat CreateAutoAnimatedFloat(this View item, AnimateOperation animate_operation)
        {
            AutoAnimatedFloat auto_animated_float = new AutoAnimatedFloat<PeriodicProcess_Android>(animate_operation);

            auto_animated_float.OnAnimate += delegate() {
                item.Invalidate();
            };

            return auto_animated_float;
        }
    }
}