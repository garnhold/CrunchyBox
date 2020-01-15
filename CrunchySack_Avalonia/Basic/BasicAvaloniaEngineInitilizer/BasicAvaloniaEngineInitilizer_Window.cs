using System;
using System.IO;

using Avalonia;
using Avalonia.Controls;

namespace Crunchy.Sack_Avalonia
{
    using Dough;
    using Sack;
    using Sack.WinCommon;
    
    [BasicAvaloniaEngineInitilizer]
    static public class BasicAvaloniaEngineInitilizer_Window
    {
        [BasicAvaloniaEngineInitilizer]
        static public void Initilize(AvaloniaEngine engine)
        {
            engine.AddPublicPropertyAttributeLinksForType<Window>();
            engine.Add(
                AvaloniaInstancers.Simple("Window", () => new Window()),

                AvaloniaInfos.AttributeFunction<Window>("on_close", (w, f) => w.Closed += f.GetEventHandler())
            );
        }
    }
}