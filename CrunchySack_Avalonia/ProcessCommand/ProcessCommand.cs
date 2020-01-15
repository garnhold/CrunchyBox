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
    
    public class ProcessCommand : ICommand
    {
        private Process<object> process;

        public event EventHandler CanExecuteChanged;

        public ProcessCommand(Process<object> p)
        {
            process = p;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            process(parameter);
        }
    }
}