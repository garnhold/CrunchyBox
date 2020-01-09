using System;
using System.IO;

using System.Windows;
using System.Windows.Controls;

namespace Crunchy.Sack.WPF
{
    using Dough;
    using Sack;
    
    [BasicWPFEngineInitilizer]
    static public class BasicWPFEngineInitilizer_Layouts_Grid
    {
        [BasicWPFEngineInitilizer]
        static public void Initilize(WPFEngine engine)
        {
            engine.Add(
                WPFInstancers.Simple("Grid", () => new Grid()),

                WPFInfos.AttributeLink<Grid, string>("columns", (g, s) => g.SetColumnDefinitionString(s), g => g.GetColumnDefinitionString()),
                WPFInfos.AttributeLink<Grid, string>("rows", (g, s) => g.SetRowDefinitionString(s), g => g.GetRowDefinitionString()),

                WPFInfos.Children<Grid>(g => g.Children),

                WPFInfos.AttributeLink<UIElement, int>("column", Grid.ColumnProperty),
                WPFInfos.AttributeLink<UIElement, int>("row", Grid.RowProperty),

                WPFInfos.AttributeLink<UIElement, int>("column_span", Grid.ColumnSpanProperty),
                WPFInfos.AttributeLink<UIElement, int>("row_span", Grid.RowSpanProperty)
            );

            engine.Add(
                WPFInstancers.Simple("GridSplitter", () => new GridSplitter())
            );
        }
    }
}