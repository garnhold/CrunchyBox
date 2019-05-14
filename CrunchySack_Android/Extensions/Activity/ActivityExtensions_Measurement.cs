using System;
using System.IO;

using Android;
using Android.App;
using Android.Views;
using Android.Content;
using Android.Content.Res;

using CrunchyDough;
using CrunchySack;

namespace CrunchySack_Android
{
    static public class ActivityExtensions_Measurement
    {
        static public AndroidMeasurer GetAndroidMeasurer(this Activity item)
        {
            return item.Resources.DisplayMetrics.GetAndroidMeasurer();
        }
    }
}