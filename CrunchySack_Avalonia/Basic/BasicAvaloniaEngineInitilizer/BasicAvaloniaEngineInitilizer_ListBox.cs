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
    static public class BasicAvaloniaEngineInitilizer_ListBox
    {
        [BasicAvaloniaEngineInitilizer]
        static public void Initilize(AvaloniaEngine engine)
        {
            engine.AddSimpleInstancer<ListBox>();
            engine.AddAvaloniaPropertyAttributeLinksForType<ListBox>();
            engine.AddReOrgChildren<ListBox, ListBoxItem>((b, o) => b.Items = o);

            engine.AddSimpleInstancer<ListBoxItem>();
            engine.AddAvaloniaPropertyAttributeLinksForType<ListBoxItem>();
        }
    }
}