using System;
using System.IO;

using Avalonia;
using Avalonia.Controls;

namespace Crunchy.Sack_Avalonia
{
    using Dough;
    using Sack;
    using Sack_WinCommon;
    
    [BasicAvaloniaEngineInitilizer]
    static public class BasicAvaloniaEngineInitilizer_Window
    {
        [BasicAvaloniaEngineInitilizer]
        static public void Initilize(AvaloniaEngine engine)
        {
            engine.AddSimpleInstancer<Window>();
            engine.AddAvaloniaPropertyAttributeLinksForType<Window>();

            engine.AddAttributeFunction<Window>("on_close", (w, s) => w.Closed += s.GetEventHandler());
        }
    }
}