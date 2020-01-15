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
    
    static public class FrameworkElementExtensions_InputBindings
    {
        static public void AddInputBinding(this FrameworkElement item, ICommand command, InputGesture gesture)
        {
            item.InputBindings.Add(new InputBinding(command, gesture));
        }

        static public void AddInputBinding(this FrameworkElement item, FunctionSyncro function_syncro, InputGesture gesture)
        {
            item.AddInputBinding(function_syncro.GetCommand(), gesture);
        }

        static public void AddInputBinding(this FrameworkElement item, FunctionSyncro function_syncro, MouseAction mouse_action)
        {
            item.AddInputBinding(function_syncro, new MouseGesture(mouse_action));
        }
        static public void AddInputBinding(this FrameworkElement item, FunctionSyncro function_syncro, MouseAction mouse_action, ModifierKeys modifiers)
        {
            item.AddInputBinding(function_syncro, new MouseGesture(mouse_action, modifiers));
        }
        static public void AddInputBinding(this FrameworkElement item, FunctionSyncro function_syncro, Key key)
        {
            item.AddInputBinding(function_syncro, new KeyGesture(key));
        }
        static public void AddInputBinding(this FrameworkElement item, FunctionSyncro function_syncro, Key key, ModifierKeys modifiers)
        {
            item.AddInputBinding(function_syncro, new KeyGesture(key, modifiers));
        }
    }
}