using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using System.Windows.Forms;

namespace Crunchy.Sack.WinForms
{
    using Dough;
    using Noodle;
    using Sack;

    static public class ControlExtensions_Parent
    {
        static public IEnumerable<Control> GetParents(this Control item)
        {
            return item.Traverse(c => c.Parent);
        }

        static public T GetParent<T>(this Control item)
        {
            return item.GetParents().FindFirstOfType<Control, T>();
        }
    }
}