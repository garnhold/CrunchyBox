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
    static public class BasicAvaloniaEngineInitilizer_ScrollViewer
    {
        [BasicAvaloniaEngineInitilizer]
        static public void Initilize(AvaloniaEngine engine)
        {
            engine.AddSimpleInstancer<ScrollViewer>();
            engine.AddAvaloniaPropertyAttributeLinksForType<ScrollViewer>();

            engine.AddChildren<ScrollViewer, Control>(v => v.Content = null, (v, c) => v.Content = c);
        }
    }
}