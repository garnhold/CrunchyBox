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
    
    static public class MeasureSpecModeExtensions
    {
        static public int CalculateMeasurement(this MeasureSpecMode item, int measure_spec_size, int preferred_measurement)
        {
            switch (item)
            {
                case MeasureSpecMode.Exactly: return measure_spec_size;
                case MeasureSpecMode.AtMost: return preferred_measurement.BindBelow(measure_spec_size);
                case MeasureSpecMode.Unspecified: return preferred_measurement;
            }

            throw new UnaccountedBranchException("item", item);
        }
    }
}