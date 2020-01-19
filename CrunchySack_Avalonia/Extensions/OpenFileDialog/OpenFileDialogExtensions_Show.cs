using System;
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
        static public void DoDialog(this OpenFileDialog item, Process<string[]> process)
        {
            item.ShowAsync(AvaloniaEngine.GetMainWindow())
                .ContinueWith(t => t.Result.IfNotNull(r => process(r)));
        }
        static public void DoSingleFileDialog(this OpenFileDialog item, Process<string> process)
        {
            item.DoDialog(fs => process(fs.GetFirst()));
        }
    }
}