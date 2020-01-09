using System;
using System.IO;

using Android;
using Android.App;
using Android.Views;
using Android.Widget;

namespace Crunchy.Sack_Android
{
    using Dough;
    using Sack;
    
    public class AndroidMeasurer : PixelMeasurer
    {
        public AndroidMeasurer(double d) : base(d)
        {
            Add(new UnitDefinition_Constant("MATCH_PARENT", -1));
            Add(new UnitDefinition_Constant("WRAP_CONTENT", -2));
        }
    }
}