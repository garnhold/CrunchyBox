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
            engine.AddSimpleInstancer<ContextMenu>();
            engine.AddAvaloniaPropertyAttributeLinksForType<ContextMenu>();

            engine.AddSimpleInstancer<Menu>();
            engine.AddAvaloniaPropertyAttributeLinksForType<Menu>();

            engine.AddSimpleInstancer<MenuItem>();
            engine.AddAvaloniaPropertyAttributeLinksForType<MenuItem>();
            engine.AddAttributeFunction<MenuItem>("command", (i, s) => i.Command = s.GetCommand());
            engine.AddAttributeFunction<MenuItem>("action", MenuItem.ClickEvent);

            engine.AddSimpleInstancer<Separator>();
            engine.AddAvaloniaPropertyAttributeLinksForType<Separator>();

            engine.AddAttributeValue<Control, ContextMenu>("context_menu", (f, e) => { f.ContextMenu = e; f.InvalidateVisual(); });
        }
    }
}