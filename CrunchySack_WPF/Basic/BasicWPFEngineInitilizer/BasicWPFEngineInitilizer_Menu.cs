using System;
using System.IO;

using System.Windows;
using System.Windows.Controls;

namespace Crunchy.Sack_WPF
{
    using Dough;
    using Sack;
    
    [BasicWPFEngineInitilizer]
    static public class BasicWPFEngineInitilizer_Menu
    {
        [BasicWPFEngineInitilizer]
        static public void Initilize(WPFEngine engine)
        {
            engine.AddAttributeValue<FrameworkElement, ContextMenu>("context_menu", (f, e) => { f.ContextMenu = e; f.InvalidateVisual(); });

            engine.AddSimpleInstancer<ContextMenu>();
            engine.AddSimpleInstancer<Menu>();

            engine.AddSimpleInstancer<MenuItem>();

            engine.AddAttributeFunction<MenuItem>("command", (m, a) => m.Command = a.GetCommand());
            engine.AddAttributeFunction<MenuItem>("action", (m, a) => m.Click += a.GetRoutedEventHandler());

            engine.AddSimpleInstancer<Separator>();
        }
    }
}