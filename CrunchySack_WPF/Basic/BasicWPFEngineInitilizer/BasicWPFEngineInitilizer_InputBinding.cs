using System;
using System.IO;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Crunchy.Sack_WPF
{
    using Dough;
    using Noodle;
    using Sack;
    
    [BasicWPFEngineInitilizer]
    static public class BasicWPFEngineInitilizer_InputBinding
    {
        [BasicWPFEngineInitilizer]
        static public void Initilize(WPFEngine engine)
        {
            engine.AddAttributeChildren<UIElement>("input_bindings", e => e.InputBindings);

            engine.AddSimpleInstancer("InputBinding", () => new InputBinding(EmptyCommand.INSTANCE, EmptyInputGesture.INSTANCE));

            engine.AddAttributeFunction<InputBinding>("action", (b, a) => b.Command = a.GetCommand());
            engine.AddAttributeLink<InputBinding>("gesture", "Gesture");

            engine.AddSimpleConstructor<MouseGesture, string, string>("MouseGesture",
                (a, m) => new MouseGesture(a.ConvertEX<MouseAction>(), m.ConvertEX<ModifierKeys>())
            );

            engine.AddSimpleConstructor<KeyGesture, string, string>("KeyGesture",
                (k, m) => new KeyGesture(k.ConvertEX<Key>(), m.ConvertEX<ModifierKeys>())
            );
        }
    }
}