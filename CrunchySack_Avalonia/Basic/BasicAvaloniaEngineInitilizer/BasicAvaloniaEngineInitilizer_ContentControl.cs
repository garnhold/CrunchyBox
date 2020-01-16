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
    static public class BasicAvaloniaEngineInitilizer_ContentControl
    {
        [BasicAvaloniaEngineInitilizer]
        static public void Initilize(AvaloniaEngine engine)
        {
            engine.Add(
                AvaloniaInfos.AttributeLink<ContentControl, object>("content", ContentControl.ContentProperty),
                AvaloniaInfos.Children<ContentControl, Control>(c => c.Content = null, (c, e) => c.Content = e)
            );
        }
    }
}