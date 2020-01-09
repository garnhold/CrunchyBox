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
    static public class BasicAndroidEngineInitilizer_Button
    {
        [BasicAndroidEngineInitilizer]
        static public void Initilize(AndroidEngine engine)
        {
            engine.Add(
                AndroidInstancers.Simple("Button", r => new Button(r)),

                AndroidInfos.AttributeFunction<Button>("action", (s, a) => s.Click += a.GetEventHandler()),
                AndroidInfos.AttributeFunction<Button>("down", (s, a) => s.Touch += delegate(object v, View.TouchEventArgs e) { if (e.Event.Action == MotionEventActions.Down) { a.Execute(); e.Handled = true; } }),
                AndroidInfos.AttributeFunction<Button>("up", (s, a) => s.Touch += delegate(object v, View.TouchEventArgs e) { if (e.Event.Action == MotionEventActions.Up) { a.Execute(); e.Handled = true; } })
            );
        }
    }
}