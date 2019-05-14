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
    [BasicAndroidEngineInitilizer]
    static public class BasicAndroidEngineInitilizer_General
    {
        [BasicAndroidEngineInitilizer]
        static public void Initilize(AndroidEngine engine)
        {
            engine.Add(
                AndroidInfos.AttributeLink<View, int>("min_width", (s, a) => s.SetMinimumWidth(a), s => s.MinimumWidth),
                AndroidInfos.AttributeLink<View, int>("min_height", (s, a) => s.SetMinimumHeight(a), s => s.MinimumHeight),

                AndroidInfos.AttributeLink<View, bool>("keep_screen_on", (s, a) => s.KeepScreenOn = a, s => s.KeepScreenOn)
            );
        }
    }
}