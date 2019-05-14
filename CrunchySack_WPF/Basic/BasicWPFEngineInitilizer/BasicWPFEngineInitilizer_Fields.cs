using System;
using System.IO;

using System.Windows;
using System.Windows.Controls;

using CrunchyDough;
using CrunchySack;

namespace CrunchySack_WPF
{
    [BasicWPFEngineInitilizer]
    static public class BasicWPFEngineInitilizer_Fields
    {
        [BasicWPFEngineInitilizer]
        static public void Initilize(WPFEngine engine)
        {
            engine.Add(
                WPFInstancers.Simple("TextField", () => new TextBox()),

                WPFInstancers.Variation<TextBox>("SmallField", "TextField", b => {
                    b.GotFocus += (s, e) => b.SelectAll();
                    b.GotKeyboardFocus += (s, e) => b.SelectAll();
                    b.GotMouseCapture += (s, e) => b.SelectAll();
                }),

                WPFInstancers.Variation<TextBox>("StringField", "SmallField", b => { }),
                WPFInstancers.Variation<TextBox>("IntField", "SmallField", b => { }),
                WPFInstancers.Variation<TextBox>("FloatField", "SmallField", b => { }),

                WPFInfos.AttributeLink<TextBox, string>("text", TextBox.TextProperty),
                WPFInfos.AttributeLink<TextBox, string>("value", TextBox.TextProperty)
            );
        }
    }
}