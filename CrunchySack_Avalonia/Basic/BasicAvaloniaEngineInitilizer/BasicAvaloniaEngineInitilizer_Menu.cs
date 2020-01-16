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
    static public class BasicAvaloniaEngineInitilizer_Menu
    {
        [BasicAvaloniaEngineInitilizer]
        static public void Initilize(AvaloniaEngine engine)
        {
            engine.AddAvaloniaPropertyAttributeLinksForType<ContextMenu>();
            engine.AddAvaloniaPropertyAttributeLinksForType<Menu>();
            engine.AddAvaloniaPropertyAttributeLinksForType<MenuItem>();
            engine.AddAvaloniaPropertyAttributeLinksForType<Separator>();

            engine.Add(
                 AvaloniaInfos.AttributeValue<Control, ContextMenu>("context_menu", (f, e) => { f.ContextMenu = e; f.InvalidateVisual(); }),

                AvaloniaInstancers.Simple("ContextMenu", () => new ContextMenu()),
                AvaloniaInstancers.Simple("Menu", () => new Menu()),

                AvaloniaInstancers.Simple("MenuItem", () => new MenuItem()),

                AvaloniaInfos.AttributeFunction<MenuItem>("command", (m, s) => m.Command = s.GetCommand()),
                AvaloniaInfos.AttributeFunction<MenuItem>("action", Control.PointerPressedEvent),

                AvaloniaInstancers.Simple("Separator", () => new Separator())
            );
        }
    }
}