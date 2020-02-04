using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using Gtk;

namespace Crunchy.Sack_Gtk
{
    using Dough;
    using Noodle;
    using Sack;
    
    static public class FileChooserDialogExtensions_Show
    {
        static public void DoDialog(this FileChooserDialog item, Process<string> process)
        {
            item.Destroyed += delegate {
                if (item.Filename.IsVisible())
                    process(item.Filename);
            };

            item.Run();
        }

        static public void DoDialog(this FileChooserDialog item, Process<string[]> process)
        {
            item.Destroyed += delegate {
                if (item.Filename.IsVisible())
                    process(item.Filenames);
            };

            item.Run();
        }
    }
}