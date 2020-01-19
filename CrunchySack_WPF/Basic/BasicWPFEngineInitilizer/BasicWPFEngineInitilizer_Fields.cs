using System;
using System.IO;

using System.Windows;
using System.Windows.Controls;

namespace Crunchy.Sack_WPF
{
    using Dough;
    using Sack;
    
    [BasicWPFEngineInitilizer]
    static public class BasicWPFEngineInitilizer_Fields
    {
        [BasicWPFEngineInitilizer]
        static public void Initilize(WPFEngine engine)
        {
            engine.AddSimpleInstancer<TextBox>("TextField");

            engine.AddVariationInstancer<TextBox>("SmallField", "TextField", b => {
                b.GotFocus += (s, e) => b.SelectAll();
                b.GotKeyboardFocus += (s, e) => b.SelectAll();
                b.GotMouseCapture += (s, e) => b.SelectAll();
            });

            engine.AddVariationInstancer<TextBox>("StringField", "SmallField", b => { });
            engine.AddVariationInstancer<TextBox>("IntField", "SmallField", b => { });
            engine.AddVariationInstancer<TextBox>("FloatField", "SmallField", b => { });

            engine.AddAttributeLink<TextBox, string>("text", TextBox.TextProperty);
            engine.AddAttributeLink<TextBox, string>("value", TextBox.TextProperty);
        }
    }
}