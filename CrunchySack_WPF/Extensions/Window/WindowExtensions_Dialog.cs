using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using System.Windows;

namespace Crunchy.Sack_WPF
{
    using Dough;
    using Noodle;
    using Sack;
    
    static public class WindowExtensions_Dialog
    {
        static public void OkClose(this Window item)
        {
            item.DialogResult = true;
            item.Close();
        }

        static public void CancelClose(this Window item)
        {
            item.DialogResult = false;
            item.Close();
        }
    }
}