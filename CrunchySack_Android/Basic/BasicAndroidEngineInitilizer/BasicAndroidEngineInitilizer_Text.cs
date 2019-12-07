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
    static public class BasicAndroidEngineInitilizer_Text
    {
        [BasicAndroidEngineInitilizer]
        static public void Initilize(AndroidEngine engine)
        {
            engine.Add(
                AndroidInstancers.Simple("Text", r => new TextView(r)),
                AndroidInstancers.Variation<TextView>("Label", "Text", v => v.TextSize = 12.0f),
                AndroidInstancers.Variation<TextView>("Header", "Text", v => v.TextSize = 24.0f),
                AndroidInstancers.Variation<TextView>("Title", "Text", v => v.TextSize = 32.0f),

                AndroidInfos.AttributeLink<TextView, string>("text", (t, s) => t.Text = s, s => s.Text),
                AndroidInfos.AttributeLink<TextView, string>("value", (t, s) => t.Text = s, s => s.Text)
            );
        }
    }
}