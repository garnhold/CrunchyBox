﻿using System;
using System.IO;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Crunchy.Sack_WPF
{
    using Dough;
    using Noodle;
    using Sack;
    
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