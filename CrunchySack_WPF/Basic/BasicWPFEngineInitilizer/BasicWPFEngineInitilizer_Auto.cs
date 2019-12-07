using System;
using System.IO;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace Crunchy.Sack_WPF
{
    using Dough;
    using Sack;
    
    [BasicWPFEngineInitilizer]
    static public class BasicWPFEngineInitilizer_Auto
    {
        [BasicWPFEngineInitilizer]
        static public void Initilize(WPFEngine engine)
        {
            engine.AddInspectedComponentsForTypes(
                typeof(UIElement),
                typeof(FrameworkElement),

                typeof(Border),
                typeof(Button),
                typeof(ComboBox),
                typeof(ContentControl),
                typeof(Control),
                typeof(Decorator),
                typeof(TextBoxBase),
                typeof(TextBox),
                typeof(TextBlock),
                typeof(HeaderedContentControl),
                typeof(HeaderedItemsControl),
                typeof(Image),
                typeof(ItemsControl),
                typeof(Panel),
                typeof(StackPanel),
                typeof(Grid),
                typeof(DockPanel),
                typeof(Menu),
                typeof(MenuItem),
                typeof(ContextMenu),
                typeof(ScrollViewer),
                typeof(Selector),
                typeof(TabControl),
                typeof(TabItem),
                typeof(TreeView),
                typeof(TreeViewItem),
                typeof(Window)
            );
        }
    }
}