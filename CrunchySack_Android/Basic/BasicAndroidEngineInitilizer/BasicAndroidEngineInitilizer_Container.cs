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
    
    [BasicAndroidEngineInitilizer]
    static public class BasicAndroidEngineInitilizer_Container
    {
        [BasicAndroidEngineInitilizer]
        static public void Initilize(AndroidEngine engine)
        {
            engine.Add(
                AndroidInfos.Children<ViewGroup, View>(p => p.RemoveAllViews(), (p, c) => { p.AddView(c); p.Invalidate(); p.RequestLayout(); }),

                AndroidInfos.AttributeValueLayout<ViewGroup.LayoutParams, string>("width", (r, p, v) => p.Width = r.ParseMeasurement(v)),
                AndroidInfos.AttributeValueLayout<ViewGroup.LayoutParams, string>("height", (r, p, v) => p.Height = r.ParseMeasurement(v)),

                AndroidInfos.AttributeValueLayout<LinearLayout.LayoutParams, float>("weight", (r, p, v) => p.Weight = v),
                AndroidInfos.AttributeValueLayout<LinearLayout.LayoutParams, GravityFlags>("gravity", (r, p, v) => p.Gravity = v)
            );
        }
    }
}