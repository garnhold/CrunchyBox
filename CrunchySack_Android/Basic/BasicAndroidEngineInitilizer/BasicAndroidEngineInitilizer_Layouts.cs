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
    static public class BasicAndroidEngineInitilizer_Layouts
    {
        [BasicAndroidEngineInitilizer]
        static public void Initilize(AndroidEngine engine)
        {
            engine.Add(
                AndroidInstancers.Simple("HorizontalLayout", r => new LinearLayout(r) { Orientation = Orientation.Horizontal }),
                AndroidInstancers.Simple("VerticalLayout", r => new LinearLayout(r) { Orientation = Orientation.Vertical }),

                AndroidInstancers.Simple("ScrollLayout", r => new ScrollView(r)),

                AndroidInstancers.Simple("GridLayout", r => new GridLayout(r)),
                AndroidInfos.AttributeLink<GridLayout, int>("number_columns", (g, i) => g.ColumnCount = i, g => g.ColumnCount),

                AndroidInstancers.Simple("TableLayout", r => new TableLayout(r)),
                AndroidInstancers.Simple("TableRow", r => new TableRow(r))
            );
        }
    }
}