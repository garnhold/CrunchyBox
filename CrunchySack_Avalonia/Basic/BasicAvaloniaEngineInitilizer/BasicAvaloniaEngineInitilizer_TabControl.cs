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
    static public class BasicAvaloniaEngineInitilizer_TabControl
    {
        [BasicAvaloniaEngineInitilizer]
        static public void Initilize(AvaloniaEngine engine)
        {
            engine.AddSimpleInstancer<TabControl>();
            engine.AddAvaloniaPropertyAttributeLinksForType<TabControl>();

            engine.AddSimpleInstancer<TabItem>();
            engine.AddAvaloniaPropertyAttributeLinksForType<TabItem>();
        }
    }
}