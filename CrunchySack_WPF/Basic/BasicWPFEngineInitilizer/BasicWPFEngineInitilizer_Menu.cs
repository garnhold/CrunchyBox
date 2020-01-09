using System;
using System.IO;

using System.Windows;
using System.Windows.Controls;

namespace Crunchy.Sack.WPF
{
    using Dough;
    using Sack;
    
    [BasicWPFEngineInitilizer]
    static public class BasicWPFEngineInitilizer_Menu
    {
        [BasicWPFEngineInitilizer]
        static public void Initilize(WPFEngine engine)
        {
            engine.Add(
                WPFInfos.AttributeValue<FrameworkElement, ContextMenu>("context_menu", (f, e) => { f.ContextMenu = e; f.InvalidateVisual(); }),

                WPFInstancers.Simple("ContextMenu", () => new ContextMenu()),
                WPFInstancers.Simple("Menu", () => new Menu()),

                WPFInstancers.Simple("MenuItem", () => new MenuItem()),

                WPFInfos.AttributeFunction<MenuItem>("command", (m, a) => m.Command = a.GetCommand()),
                WPFInfos.AttributeFunction<MenuItem>("action", (m, a) => m.Click += a.GetRoutedEventHandler()),

                WPFInstancers.Simple("Separator", () => new Separator())
            );
        }
    }
}