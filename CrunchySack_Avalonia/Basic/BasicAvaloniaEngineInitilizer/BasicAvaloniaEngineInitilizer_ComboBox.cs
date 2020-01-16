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
    static public class BasicAvaloniaEngineInitilizer_ComboBox
    {
        [BasicAvaloniaEngineInitilizer]
        static public void Initilize(AvaloniaEngine engine)
        {
            engine.AddAvaloniaPropertyAttributeLinksForType<ComboBox>();
            engine.Add(
                AvaloniaInstancers.Simple("ComboBox", () => new ComboBox())
            );
        }
    }
}