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
            engine.AddSimpleInstancer<TextBlock>("Text");

            engine.AddVariationInstancer<TextBlock>("Label", "Text", t => t.FontSize = 12.0);
            engine.AddVariationInstancer<TextBlock>("Header", "Text", t => t.FontSize = 22.0);
            engine.AddVariationInstancer<TextBlock>("Title", "Text", t => t.FontSize = 33.0);

            engine.AddAttributeLink<TextBlock, string>("text", TextBlock.TextProperty);
            engine.AddAttributeLink<TextBlock, string>("value", TextBlock.TextProperty);
        }
    }
}