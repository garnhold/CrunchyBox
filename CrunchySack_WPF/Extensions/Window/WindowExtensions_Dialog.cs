using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using System.Windows;

using CrunchyDough;
using CrunchyNoodle;
using CrunchySack;

namespace CrunchySack_WPF
{
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