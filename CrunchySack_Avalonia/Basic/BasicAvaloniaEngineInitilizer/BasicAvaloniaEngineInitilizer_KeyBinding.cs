﻿using System;
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
            engine.AddSimpleInstancer<KeyBinding>();
            engine.AddAvaloniaPropertyAttributeLinksForType<KeyBinding>();
            engine.AddAttributeFunction<KeyBinding>("action", (b, s) => b.Command = s.GetCommand());

            engine.AddSimpleConstructor<KeyGesture, string, string>("KeyGesture",
                (k, m) => new KeyGesture(k.ConvertEX<Key>(), m.ConvertEX<KeyModifiers>())
            );

            engine.AddAttributeChildren<Control>("key_bindings", e => e.KeyBindings);
        }
    }
}