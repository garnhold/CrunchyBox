using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using Avalonia;
using Avalonia.Controls;

namespace Crunchy.Sack_Avalonia
{
    using Dough;
    using Noodle;
    using Sack;
    
    static public class FileDialogFilterExtensions
    {
        static public FileDialogFilter Create(string name, string extensions)
        {
            return new FileDialogFilter() {
                Name = name,
                Extensions = extensions.SplitOn("|", ",", " ").ToList()
            };
        }
    }
}