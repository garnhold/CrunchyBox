using System;
using System.IO;

using Android;
using Android.App;
using Android.Views;
using Android.Content;
using Android.Content.Res;

namespace Crunchy.Sack_Android
{
    using Dough;
    using Sack;
    
    static public class ActivityExtensions_Measurement
    {
        static public AndroidMeasurer GetAndroidMeasurer(this Activity item)
        {
            return item.Resources.DisplayMetrics.GetAndroidMeasurer();
        }
    }
}