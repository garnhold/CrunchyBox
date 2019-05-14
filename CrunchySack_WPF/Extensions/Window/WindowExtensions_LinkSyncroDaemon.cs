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
    static public class WindowExtensions_LinkSyncroDaemon
    {
        static public void AttachLinkSyncroDaemon(this Window item, LinkSyncroDaemon to_attach)
        {
            if (item.IsVisible)
                to_attach.Start();
            else
                to_attach.StopClear();

            item.IsVisibleChanged += delegate(object sender, DependencyPropertyChangedEventArgs e) {
                if ((bool)e.NewValue)
                    to_attach.Start();
                else
                    to_attach.StopClear();
            };

            item.Closed += delegate(object sender, EventArgs e) {
                to_attach.StopClear();
            };
        }
    }
}