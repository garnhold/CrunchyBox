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
    static public class ViewExtensions_Measurement
    {
        static public int ParseMeasurement(this View item, string measurement, double world = 1.0)
        {
            return (int)item.GetAndroidMeasurer().Parse(measurement);
        }

        static public AndroidMeasurer GetAndroidMeasurer(this View item)
        {
            return item.Resources.DisplayMetrics.GetAndroidMeasurer();
        }
    }
}