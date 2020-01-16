using System;
using System.IO;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;

namespace Crunchy.Sack_Avalonia
{
    using Dough;
    using Noodle;
    using Sack;
    using Sack_WinCommon;
    
    [BasicAvaloniaEngineInitilizer]
    static public class BasicAvaloniaEngineInitilizer_KeyBinding
    {
        [BasicAvaloniaEngineInitilizer]
        static public void Initilize(AvaloniaEngine engine)
        {
            engine.Add(
                AvaloniaInfos.AttributeChildren<Control>("key_bindings", e => e.KeyBindings)
            );

            engine.AddAvaloniaPropertyAttributeLinksForType<KeyBinding>();
            engine.Add(
                AvaloniaInstancers.Simple("KeyBinding", () => new KeyBinding()),

                AvaloniaInfos.AttributeFunction<KeyBinding>("action", (b, a) => b.Command = a.GetCommand())
            );

            engine.Add(
                AvaloniaConstructors.Simple<KeyGesture, string, string>("KeyGesture",
                    (k, m) => new KeyGesture(k.ConvertEX<Key>(), m.ConvertEX<KeyModifiers>())
                )
            );
        }
    }
}