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
    static public class BasicAvaloniaEngineInitilizer_TabControl
    {
        [BasicAvaloniaEngineInitilizer]
        static public void Initilize(AvaloniaEngine engine)
        {
            engine.AddAvaloniaPropertyAttributeLinksForType<TabControl>();
            engine.AddAvaloniaPropertyAttributeLinksForType<TabItem>();

            engine.Add(
                AvaloniaInstancers.Simple("TabControl", () => new TabControl()),
                AvaloniaInstancers.Simple("TabItem", () => new TabItem())
            );
        }
    }
}