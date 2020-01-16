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
    static public class BasicAvaloniaEngineInitilizer_Button
    {
        [BasicAvaloniaEngineInitilizer]
        static public void Initilize(AvaloniaEngine engine)
        {
            engine.AddAvaloniaPropertyAttributeLinksForType<Button>();
            engine.Add(
                AvaloniaInstancers.Simple("Button", () => new Button()),

                AvaloniaInfos.AttributeLink<Button, string>("text", Button.ContentProperty),
                AvaloniaInfos.AttributeFunction<Button>("action", Control.PointerPressedEvent),
                AvaloniaInfos.AttributeFunction<Button>("preview_action", Control.PointerPressedEvent, RoutingStrategies.Tunnel)
            );
        }
    }
}