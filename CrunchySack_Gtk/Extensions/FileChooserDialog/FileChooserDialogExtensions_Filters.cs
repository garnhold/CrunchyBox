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
    
    static public class FileChooserDialogExtensions_Filters
    {
        static public void AddFilter(this FileChooserDialog item, string name, string pattern)
        {
            item.AddFilter(FileFilterExtensions.CreatePattern(name, pattern));
        }

        static public void AddFilters(this FileChooserDialog item, IEnumerable<Tuple<string, string>> pairs)
        {
            pairs.Process(p => item.AddFilter(p.item1, p.item2));
        }
        static public void AddFilters(this FileChooserDialog item, params Tuple<string, string>[] pairs)
        {
            item.AddFilters((IEnumerable<Tuple<string, string>>)pairs);
        }
        static public void AddFilters(this FileChooserDialog item, params string[] pairs)
        {
            item.AddFilters(pairs.PairStrict());
        }
    }
}