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
    static public class BasicAvaloniaEngineInitilizer_TreeView
    {
        [BasicAvaloniaEngineInitilizer]
        static public void Initilize(AvaloniaEngine engine)
        {
            engine.AddSimpleInstancer<TreeView>();
            engine.AddAvaloniaPropertyAttributeLinksForType<TreeView>();

            engine.AddSimpleInstancer<TreeViewItem>();
            engine.AddAvaloniaPropertyAttributeLinksForType<TreeViewItem>();
        }
    }
}