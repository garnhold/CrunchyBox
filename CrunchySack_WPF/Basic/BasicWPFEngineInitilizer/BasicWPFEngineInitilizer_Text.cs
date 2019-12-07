using System;
using System.IO;

using System.Windows;
using System.Windows.Controls;

namespace Crunchy.Sack_WPF
{
    using Dough;
    using Sack;
    
    [BasicWPFEngineInitilizer]
    static public class BasicWPFEngineInitilizer_Text
    {
        [BasicWPFEngineInitilizer]
        static public void Initilize(WPFEngine engine)
        {
            engine.Add(
                WPFInstancers.Simple("Text", () => new TextBlock()),

                WPFInstancers.Variation<TextBlock>("Label", "Text", t => t.FontSize = 12.0),
                WPFInstancers.Variation<TextBlock>("Header", "Text", t => t.FontSize = 22.0),
                WPFInstancers.Variation<TextBlock>("Title", "Text", t => t.FontSize = 33.0),

                WPFInfos.AttributeLink<TextBlock, string>("text", TextBlock.TextProperty),
                WPFInfos.AttributeLink<TextBlock, string>("value", TextBlock.TextProperty)
            );
        }
    }
}