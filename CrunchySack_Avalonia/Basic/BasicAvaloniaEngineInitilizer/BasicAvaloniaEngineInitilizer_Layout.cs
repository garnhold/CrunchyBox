using System;
using System.IO;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;

namespace Crunchy.Sack_Avalonia
{
    using Dough;
    using Sack;
    using Sack_WinCommon;
    
    [BasicAvaloniaEngineInitilizer]
    static public class BasicAvaloniaEngineInitilizer_Layout
    {
        [BasicAvaloniaEngineInitilizer]
        static public void Initilize(AvaloniaEngine engine)
        {
            engine.AddAvaloniaPropertyAttributeLinksForType<Panel>();
            engine.AddChildren<Panel>(p => p.Children);

            engine.AddSimpleInstancer("HorizontalLayout", () => new StackPanel() { Orientation = Avalonia.Layout.Orientation.Horizontal });
            engine.AddSimpleInstancer("VerticalLayout", () => new StackPanel() { Orientation = Avalonia.Layout.Orientation.Vertical });
            engine.AddAvaloniaPropertyAttributeLinksForType<StackPanel>();

            engine.AddSimpleInstancer<DockPanel>();
            engine.AddAvaloniaPropertyAttributeLinksForType<DockPanel>();

            engine.AddAttributeLink<Control, Dock>("dock", DockPanel.DockProperty);

            engine.AddSimpleInstancer<Grid>();
            engine.AddAvaloniaPropertyAttributeLinksForType<Grid>();
            engine.AddAttributeLink<Grid, string>("columns", (g, s) => g.SetColumnsDefinitionString(s), g => g.GetColumnsDefinitionString());
            engine.AddAttributeLink<Grid, string>("rows", (g, s) => g.SetRowsDefinitionString(s), g => g.GetRowsDefinitionString());

            engine.AddChildren<Grid>(g => g.Children);

            engine.AddAttributeLink<Control, int>("column", Grid.ColumnProperty);
            engine.AddAttributeLink<Control, int>("row", Grid.RowProperty);

            engine.AddAttributeLink<Control, int>("column_span", Grid.ColumnSpanProperty);
            engine.AddAttributeLink<Control, int>("row_span", Grid.RowSpanProperty);

            engine.AddSimpleInstancer<GridSplitter>();
            engine.AddAvaloniaPropertyAttributeLinksForType<GridSplitter>();
        }
    }
}