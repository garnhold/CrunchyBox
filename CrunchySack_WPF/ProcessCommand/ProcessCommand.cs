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