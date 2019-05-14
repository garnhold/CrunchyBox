using System;
using System.IO;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Android.Animation;

using CrunchyDough;
using CrunchySack;

namespace CrunchySack_Android
{
    static public class MeasureSpecExtensions
    {
        static public int CalculateMeasurement(int measure_spec, int preferred_measurement)
        {
            return View.MeasureSpec.GetMode(measure_spec).CalculateMeasurement(
                View.MeasureSpec.GetSize(measure_spec),
                preferred_measurement
            );
        }
    }
}