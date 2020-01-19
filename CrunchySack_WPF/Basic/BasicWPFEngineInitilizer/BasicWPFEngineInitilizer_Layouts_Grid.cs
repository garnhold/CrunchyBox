using System;
using System.IO;

using System.Windows;
using System.Windows.Controls;

namespace Crunchy.Sack_WPF
{
    using Dough;
    using Sack;
    
    [BasicWPFEngineInitilizer]
    static public class BasicWPFEngineInitilizer_Layouts_Grid
    {
        [BasicWPFEngineInitilizer]
        static public void Initilize(WPFEngine engine)
        {
            engine.AddSimpleInstancer<Grid>();

            engine.AddAttributeLink<Grid, string>("columns", (g, s) => g.SetColumnDefinitionString(s), g => g.GetColumnDefinitionString());
            engine.AddAttributeLink<Grid, string>("rows", (g, s) => g.SetRowDefinitionString(s), g => g.GetRowDefinitionString());

            engine.AddChildren<Grid>(g => g.Children);

            engine.AddAttributeLink<UIElement, int>("column", Grid.ColumnProperty);
            engine.AddAttributeLink<UIElement, int>("row", Grid.RowProperty);

            engine.AddAttributeLink<UIElement, int>("column_span", Grid.ColumnSpanProperty);
            engine.AddAttributeLink<UIElement, int>("row_span", Grid.RowSpanProperty);

            engine.AddSimpleInstancer<GridSplitter>();
        }
    }
}