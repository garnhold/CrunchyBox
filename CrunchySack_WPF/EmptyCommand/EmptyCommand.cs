using System;
using System.IO;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

using CrunchyDough;
using CrunchyNoodle;
using CrunchySack;

namespace CrunchySack_WPF
{
    public class EmptyCommand : ICommand
    {
        static public readonly EmptyCommand INSTANCE = new EmptyCommand();

        public event EventHandler CanExecuteChanged;

        private EmptyCommand()
        {
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
        }
    }
}