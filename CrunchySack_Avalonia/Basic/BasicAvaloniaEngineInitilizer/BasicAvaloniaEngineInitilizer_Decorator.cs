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
    
    [BasicAvaloniaEngineInitilizer]
    static public class BasicAvaloniaEngineInitilizer_Decorator
    {
        [BasicAvaloniaEngineInitilizer]
        static public void Initilize(AvaloniaEngine engine)
        {
            engine.AddAttributeValue<Decorator, Control>("child", (d, c) => d.Child = c);
            engine.AddReOrgChildren<Decorator, Control>(d => d.Child = null, (d, c) => d.Child = c);
        }
    }
}