using System;
using System.IO;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;

namespace Crunchy.Sack_Avalonia
{
    using Dough;
    using Noodle;
    using Sack;
    
    static public class ControlExtensions_KeyBindings
    {
        static public void AddKeyBinding(this Control item, System.Windows.Input.ICommand command, KeyGesture gesture)
        {
            item.KeyBindings.Add(new KeyBinding() {
                Command = command,
                Gesture = gesture
            });
        }

        static public void AddKeyBinding(this Control item, FunctionSyncro function_syncro, KeyGesture gesture)
        {
            item.AddKeyBinding(function_syncro.GetCommand(), gesture);
        }

        static public void AddKeyBinding(this Control item, FunctionSyncro function_syncro, Key key)
        {
            item.AddKeyBinding(function_syncro, new KeyGesture(key));
        }
        static public void AddKeyBinding(this Control item, FunctionSyncro function_syncro, Key key, KeyModifiers modifiers)
        {
            item.AddKeyBinding(function_syncro, new KeyGesture(key, modifiers));
        }
    }
}