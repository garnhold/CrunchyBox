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

namespace Crunchy.Sack_Android
{
    using Dough;
    using Sack;
    
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