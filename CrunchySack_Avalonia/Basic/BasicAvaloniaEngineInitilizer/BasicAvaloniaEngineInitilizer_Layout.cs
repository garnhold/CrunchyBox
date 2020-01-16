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
            engine.Add(
                AvaloniaInfos.Children<Panel>(p => p.Children)
            );

            engine.AddAvaloniaPropertyAttributeLinksForType<StackPanel>();
            engine.Add(
                AvaloniaInstancers.Simple("HorizontalLayout", () => new StackPanel() { Orientation = Avalonia.Layout.Orientation.Horizontal }),
                AvaloniaInstancers.Simple("VerticalLayout", () => new StackPanel() { Orientation = Avalonia.Layout.Orientation.Vertical })
            );

            engine.AddAvaloniaPropertyAttributeLinksForType<DockPanel>();
            engine.Add(
                AvaloniaInstancers.Simple("DockPanel", () => new DockPanel()),

                AvaloniaInfos.AttributeLink<Control, Dock>("dock", DockPanel.DockProperty)
            );

            engine.AddAvaloniaPropertyAttributeLinksForType<Grid>();
            engine.Add(
                AvaloniaInstancers.Simple("Grid", () => new Grid()),

                AvaloniaInfos.AttributeLink<Grid, string>("columns", (g, s) => g.SetColumnsDefinitionString(s), g => g.GetColumnsDefinitionString()),
                AvaloniaInfos.AttributeLink<Grid, string>("rows", (g, s) => g.SetRowsDefinitionString(s), g => g.GetRowsDefinitionString()),

                AvaloniaInfos.Children<Grid>(g => g.Children),

                AvaloniaInfos.AttributeLink<Control, int>("column", Grid.ColumnProperty),
                AvaloniaInfos.AttributeLink<Control, int>("row", Grid.RowProperty),

                AvaloniaInfos.AttributeLink<Control, int>("column_span", Grid.ColumnSpanProperty),
                AvaloniaInfos.AttributeLink<Control, int>("row_span", Grid.RowSpanProperty)
            );

            engine.AddAvaloniaPropertyAttributeLinksForType<GridSplitter>();
            engine.Add(
                AvaloniaInstancers.Simple("GridSplitter", () => new GridSplitter())
            );
        }
    }
}