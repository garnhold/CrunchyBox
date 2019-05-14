using System;
using System.IO;

using Android;
using Android.App;
using Android.Views;
using Android.Widget;

using CrunchyDough;
using CrunchySack;

namespace CrunchySack_Android
{
    public class AndroidMeasurer : PixelMeasurer
    {
        public AndroidMeasurer(double d) : base(d)
        {
            Add(new UnitDefinition_Constant("MATCH_PARENT", -1));
            Add(new UnitDefinition_Constant("WRAP_CONTENT", -2));
        }
    }
}