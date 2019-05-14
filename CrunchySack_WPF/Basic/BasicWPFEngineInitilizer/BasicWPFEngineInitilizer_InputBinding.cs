﻿using System;
using System.IO;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

using CrunchyDough;
using CrunchyNoodle;
using CrunchySack;

namespace CrunchySack_WPF
{
    [BasicWPFEngineInitilizer]
    static public class BasicWPFEngineInitilizer_InputBinding
    {
        [BasicWPFEngineInitilizer]
        static public void Initilize(WPFEngine engine)
        {
            engine.Add(
                WPFInfos.AttributeChildren<UIElement>("input_bindings", e => e.InputBindings)
            );

            engine.Add(
                WPFInstancers.Simple("InputBinding", () => new InputBinding(EmptyCommand.INSTANCE, EmptyInputGesture.INSTANCE)),

                WPFInfos.AttributeFunction<InputBinding>("action", (b, a) => b.Command = a.GetCommand()),
                WPFInfos.AttributeLink<InputBinding>("gesture", "Gesture")
            );

            engine.Add(
                WPFConstructors.Simple<MouseGesture, string, string>("MouseGesture",
                    (a, m) => new MouseGesture(a.ConvertEX<MouseAction>(), m.ConvertEX<ModifierKeys>())
                )
            );

            engine.Add(
                WPFConstructors.Simple<KeyGesture, string, string>("KeyGesture", 
                    (k, m) => new KeyGesture(k.ConvertEX<Key>(), m.ConvertEX<ModifierKeys>())
                )
            );
        }
    }
}