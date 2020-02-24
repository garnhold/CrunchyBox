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
    
    static public class FileFilterExtensions
    {
        static public FileFilter CreatePattern(string name, string pattern)
        {
            FileFilter filter = new FileFilter();

            filter.Name = name;
            filter.AddPattern(pattern);
            return filter;
        }
    }
}