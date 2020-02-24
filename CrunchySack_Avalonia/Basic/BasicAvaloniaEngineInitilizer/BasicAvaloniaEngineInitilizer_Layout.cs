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
    
    [BasicAvaloniaEngineInitilizer]
    static public class BasicAvaloniaEngineInitilizer_Layout
    {
        [BasicAvaloniaEngineInitilizer]
        static public void Initilize(AvaloniaEngine engine)
        {
            engine.AddAvaloniaPropertyAttributeLinksForType<Panel>();
            engine.AddDynamicChildrenInfo<Panel>(p => p.Children);

            engine.AddSimpleInstancer("HorizontalLayout", () => new StackPanel() { Orientation = Avalonia.Layout.Orientation.Horizontal });
            engine.AddSimpleInstancer("VerticalLayout", () => new StackPanel() { Orientation = Avalonia.Layout.Orientation.Vertical });
            engine.AddAvaloniaPropertyAttributeLinksForType<StackPanel>();

            engine.AddSimpleInstancer<DockPanel>();
            engine.AddAvaloniaPropertyAttributeLinksForType<DockPanel>();

            engine.AddLinkInfo<Control, Dock>("dock", DockPanel.DockProperty);

            engine.AddSimpleInstancer<Grid>();
            engine.AddAvaloniaPropertyAttributeLinksForType<Grid>();
            engine.AddLinkInfo<Grid, string>("columns", (g, s) => g.SetColumnsDefinitionString(s), g => g.GetColumnsDefinitionString());
            engine.AddLinkInfo<Grid, string>("rows", (g, s) => g.SetRowsDefinitionString(s), g => g.GetRowsDefinitionString());

            engine.AddDynamicChildrenInfo<Grid>(g => g.Children);

            engine.AddLinkInfo<Control, int>("column", Grid.ColumnProperty);
            engine.AddLinkInfo<Control, int>("row", Grid.RowProperty);

            engine.AddLinkInfo<Control, int>("column_span", Grid.ColumnSpanProperty);
            engine.AddLinkInfo<Control, int>("row_span", Grid.RowSpanProperty);

            engine.AddSimpleInstancer<GridSplitter>();
            engine.AddAvaloniaPropertyAttributeLinksForType<GridSplitter>();
        }
    }
}