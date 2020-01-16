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
    
    static public class FileDialogExtensions_Filters
    {
        static public void AddFileFilter(this FileDialog item, string name, string extensions)
        {
            item.Filters.Add(FileDialogFilterExtensions.Create(name, extensions));
        }

        static public void AddFileFilters(this FileDialog item, IEnumerable<Tuple<string, string>> pairs)
        {
            pairs.Process(p => item.AddFileFilter(p.item1, p.item2));
        }
        static public void AddFileFilters(this FileDialog item, params Tuple<string, string>[] pairs)
        {
            item.AddFileFilters((IEnumerable<Tuple<string, string>>)pairs);
        }
        static public void AddFileFilters(this FileDialog item, params string[] pairs)
        {
            item.AddFileFilters(pairs.PairStrict());
        }

        static public void SetFileFilters(this FileDialog item, IEnumerable<Tuple<string, string>> pairs)
        {
            item.Filters.Clear();
            item.AddFileFilters(pairs);
        }
        static public void SetFileFilters(this FileDialog item, params Tuple<string, string>[] pairs)
        {
            item.Filters.Clear();
            item.AddFileFilters(pairs);
        }
        static public void SetFileFilters(this FileDialog item, params string[] pairs)
        {
            item.Filters.Clear();
            item.AddFileFilters(pairs);
        }
    }
}