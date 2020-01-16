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
    static public class BasicAvaloniaEngineInitilizer_Fields
    {
        [BasicAvaloniaEngineInitilizer]
        static public void Initilize(AvaloniaEngine engine)
        {
            engine.AddAvaloniaPropertyAttributeLinksForType<TextBox>();
            engine.Add(
                AvaloniaInstancers.Simple("TextField", () => new TextBox()),

                AvaloniaInstancers.Variation<TextBox>("SmallField", "TextField", b => {
                    b.GotFocus += (s, e) => b.SelectAllText();
                }),

                AvaloniaInstancers.Variation<TextBox>("StringField", "SmallField", b => { }),
                AvaloniaInstancers.Variation<TextBox>("IntField", "SmallField", b => { }),
                AvaloniaInstancers.Variation<TextBox>("FloatField", "SmallField", b => { }),

                AvaloniaInfos.AttributeLink<TextBox, string>("text", TextBox.TextProperty),
                AvaloniaInfos.AttributeLink<TextBox, string>("value", TextBox.TextProperty)
            );
        }
    }
}