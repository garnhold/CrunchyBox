using System;
using System.IO;

using Avalonia;
using Avalonia.Controls;

namespace Crunchy.Sack_Avalonia
{
    using Dough;
    using Sack;
    
    [BasicAvaloniaEngineInitilizer]
    static public class BasicAvaloniaEngineInitilizer_Text
    {
        [BasicAvaloniaEngineInitilizer]
        static public void Initilize(AvaloniaEngine engine)
        {
            engine.AddSimpleInstancer<TextBlock>("Text");
            engine.AddAvaloniaPropertyAttributeLinksForType<TextBlock>();

            engine.AddVariationInstancer<TextBlock>("Label", "Text", t => t.FontSize = 12.0);
            engine.AddVariationInstancer<TextBlock>("Header", "Text", t => t.FontSize = 22.0);
            engine.AddVariationInstancer<TextBlock>("Title", "Text", t => t.FontSize = 33.0);

            engine.AddLinkInfo<TextBlock, string>("value", TextBlock.TextProperty);
        }
    }
}