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
    static public class BasicAvaloniaEngineInitilizer_Decorator
    {
        [BasicAvaloniaEngineInitilizer]
        static public void Initilize(AvaloniaEngine engine)
        {
            engine.AddAvaloniaPropertyAttributeLinksForType<Decorator>();
            engine.Add(
                AvaloniaInfos.AttributeValue<Decorator, Control>("child", (d, e) => d.Child = e),
                AvaloniaInfos.Children<Decorator, Control>(d => d.Child = null, (d, e) => d.Child = e)
            );
        }
    }
}