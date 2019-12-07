using System;
using System.IO;

using Android;
using Android.App;
using Android.Views;
using Android.Content;
using Android.Content.Res;
using Android.Util;

namespace Crunchy.Sack_Android
{
    using Dough;
    using Sack;
    
    static public class DisplayMetricsExtensions_Measurement
    {
        static public int ParseMeasurement(this DisplayMetrics item, string measurement, double world = 1.0)
        {
            return (int)item.GetAndroidMeasurer().Parse(measurement);
        }

        static private readonly OperationCache<AndroidMeasurer, float> GET_ANDROID_MEASURER = new OperationCache<AndroidMeasurer, float>("GET_ANDROID_MEASURER", delegate(float dpi) {
            return new AndroidMeasurer(dpi);
        });
        static public AndroidMeasurer GetAndroidMeasurer(this DisplayMetrics item)
        {
            return GET_ANDROID_MEASURER.Fetch(item.GetDpi());
        }

        static public float GetDpi(this DisplayMetrics item)
        {
            return item.Xdpi;
        }
    }
}