﻿using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

using Avalonia;
using Avalonia.Controls;

namespace Crunchy.Sack_Avalonia
{
    using Dough;
    using Noodle;
    using Sack;
    
    static public class OpenFileDialogExtensions_Show
    {
        static public string[] ShowDialog(this OpenFileDialog item)
        {
            Task<string[]> task = item.ShowAsync(AvaloniaEngine.GetMainWindow());

            task.Wait();
            return task.Result;
        }
    }
}