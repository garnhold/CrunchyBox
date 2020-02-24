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
            engine.AddSingleDynamicChildInfo<Decorator, Control>((d, c) => d.Child = c);
            engine.AddSingleDynamicChildInfo<Decorator, Control>("child", (d, c) => d.Child = c);
        }
    }
}