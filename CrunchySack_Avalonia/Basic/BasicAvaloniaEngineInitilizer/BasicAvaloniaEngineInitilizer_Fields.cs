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
    static public class BasicAvaloniaEngineInitilizer_Fields
    {
        [BasicAvaloniaEngineInitilizer]
        static public void Initilize(AvaloniaEngine engine)
        {
            engine.AddSimpleInstancer<TextBox>("TextField");
            engine.AddAvaloniaPropertyAttributeLinksForType<TextBox>();

            engine.AddVariationInstancer<TextBox>("SmallField", "TextField", b => {
                b.GotFocus += (s, e) => b.SelectAllText();
            });

            engine.AddVariationInstancer<TextBox>("StringField", "SmallField", b => { });
            engine.AddVariationInstancer<TextBox>("IntField", "SmallField", b => { });
            engine.AddVariationInstancer<TextBox>("FloatField", "SmallField", b => { });

            engine.AddAttributeLink<TextBox, string>("text", TextBox.TextProperty);
            engine.AddAttributeLink<TextBox, string>("value", TextBox.TextProperty);
        }
    }
}