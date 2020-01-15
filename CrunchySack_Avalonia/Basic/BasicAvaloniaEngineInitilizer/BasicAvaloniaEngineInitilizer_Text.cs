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
            engine.Add(
                AvaloniaInstancers.Simple("Text", () => new TextBlock()),

                AvaloniaInstancers.Variation<TextBlock>("Label", "Text", t => t.FontSize = 12.0),
                AvaloniaInstancers.Variation<TextBlock>("Header", "Text", t => t.FontSize = 22.0),
                AvaloniaInstancers.Variation<TextBlock>("Title", "Text", t => t.FontSize = 33.0),

                AvaloniaInfos.AttributeLink<TextBlock, string>("text", TextBlock.TextProperty),
                AvaloniaInfos.AttributeLink<TextBlock, string>("value", TextBlock.TextProperty)
            );
        }
    }
}